using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProductPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClickAddToCart()
    {
        Debug.Log("Please");
    }

    public void onClickBack()
    {
        SceneManager.LoadScene("Boot");
    }
}
