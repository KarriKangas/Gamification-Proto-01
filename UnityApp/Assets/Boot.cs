using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// This is just a boot screen use to start the app
/// </summary>
public class Boot : MonoBehaviour
{

    public static int scanAmount = 0;
    public Text scanAmountText;
	void Awake()
	{
        APICaller caller = transform.GetComponent<APICaller>();
		Screen.autorotateToPortrait = true;
		Screen.autorotateToPortraitUpsideDown = true;

        scanAmountText = GameObject.Find("ScanText").GetComponent<Text>();

		// Enable vsync for the samples (avoid running mobile device at 300fps)
		QualitySettings.vSyncCount = 1;
        caller.CallAPI();
    }

	IEnumerator Start()
	{
		// When the app start, ask for the authorization to use the webcam
		yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);

		if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
		{
			throw new Exception("This Webcam library can't work without the webcam authorization");
		}

    }

    void Update()
    {
        scanAmountText.text = "Scans: " + scanAmount;

    }

	#region UI Buttons

	public void OnClickScanner()
	{
		SceneManager.LoadScene("Scanner");
	}

	#endregion
}