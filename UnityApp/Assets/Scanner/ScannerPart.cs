﻿using BarcodeScanner;
using BarcodeScanner.Scanner;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Wizcorp.Utils.Logger;

public class ScannerPart : MonoBehaviour {
    Data Data;
	private IScanner BarcodeScanner;
	public Text TextHeader;
	public RawImage Image;
	public AudioSource Audio;
    APICaller caller;
    // Disable Screen Rotation on that screen
    void Awake()
	{
        Debug.Log(this.transform);

		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;

        caller = transform.GetComponent<APICaller>();

        Data = GameObject.Find("Data").GetComponent<Data>();
        //caller.CallAPI();
    }

    void Start () {
		// Create a basic scanner
		BarcodeScanner = new Scanner();
		BarcodeScanner.Camera.Play();

		// Display the camera texture through a RawImage
		BarcodeScanner.OnReady += (sender, arg) => {
			// Set Orientation & Texture
			Image.transform.localEulerAngles = BarcodeScanner.Camera.GetEulerAngles();
			Image.transform.localScale = BarcodeScanner.Camera.GetScale();
			Image.texture = BarcodeScanner.Camera.Texture;

			// Keep Image Aspect Ratio
			var rect = Image.GetComponent<RectTransform>();
			var newHeight = rect.sizeDelta.x * BarcodeScanner.Camera.Height / BarcodeScanner.Camera.Width;
			rect.sizeDelta = new Vector2(rect.sizeDelta.x, newHeight);
		};

		// Track status of the scanner
		BarcodeScanner.StatusChanged += (sender, arg) => {
			TextHeader.text = "Status: " + BarcodeScanner.Status;
		};
	}

	/// <summary>
	/// The Update method from unity need to be propagated to the scanner
	/// </summary>
	void Update()
	{
        if (BarcodeScanner == null)
		{
			return;
		}
		BarcodeScanner.Update();
	}

	#region UI Buttons

	public void ClickStart()
	{
		if (BarcodeScanner == null)
		{
			Log.Warning("No valid camera - Click Start");
			return;
		}

		// Start Scanning
		BarcodeScanner.Scan((barCodeType, barCodeValue) => {
			BarcodeScanner.Stop();
			TextHeader.text = "Found: " + barCodeType + " / " + barCodeValue;

            Debug.Log("Now scanning...");
            Boot.scanAmount = Boot.scanAmount + 1;
            caller.CallAPI();

			Data.scans++;
            Data.experience = Data.experience + UnityEngine.Random.Range(3, 8);
			Data.currentScanID = barCodeValue;
			Debug.Log("Now loading product page with ID..." + Data.currentScanID);
            SceneManager.LoadScene("ProductPage");
            // Feedback
            Audio.Play();
           

			#if UNITY_ANDROID || UNITY_IOS
			Handheld.Vibrate();
			#endif
		});
	}

	public void ClickStop()
	{
		if (BarcodeScanner == null)
		{
			Log.Warning("No valid camera - Click Stop");
			return;
		}

		// Stop Scanning
		BarcodeScanner.Stop();
	}

	public void ClickBack()
	{
		// Try to stop the camera before loading another scene
		StartCoroutine(StopCamera(() => {
			SceneManager.LoadScene("Boot");
		}));
	}

	/// <summary>
	/// This coroutine is used because of a bug with unity (http://forum.unity3d.com/threads/closing-scene-with-active-webcamtexture-crashes-on-android-solved.363566/)
	/// Trying to stop the camera in OnDestroy provoke random crash on Android
	/// </summary>
	/// <param name="callback"></param>
	/// <returns></returns>
	public IEnumerator StopCamera(Action callback)
	{
		// Stop Scanning
		Image = null;
		BarcodeScanner.Destroy();
		BarcodeScanner = null;

		// Wait a bit
		yield return new WaitForSeconds(0.1f);

		callback.Invoke();
	}

	#endregion
}
