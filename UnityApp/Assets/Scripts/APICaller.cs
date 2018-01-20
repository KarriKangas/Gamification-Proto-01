using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APICaller : MonoBehaviour {

    string in_url = "http://localhost/wordpress2/wp-json/wc/v2/products/";
    string consumerKey = "ck_dc0ac75eed3e7ba154fdaa2189c425d1717c3a3b";
    string consumerSecret = "cs_9c764fdd279f6325c0573fb0a5f633168b9d5735";
    string requestURL = "";

    // Use this for initialization
    void Start () {
		
	}
	
	public void CallAPI()
    {
        //string weatherKey = "c1776ca3a3bc5d5959c2b4201090b5ec";
        string weatherURL = "http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=c1776ca3a3bc5d5959c2b4201090b5ec";
        /*
        OAuth_CSharp oauth = new OAuth_CSharp(consumerKey, consumerSecret);
        requestURL = oauth.GenerateRequestURL(in_url, "GET");
        */
        requestURL = weatherURL;
        Debug.Log(requestURL);
        StartCoroutine(Product());

        /*API KEYS
        key:
            ck_dc0ac75eed3e7ba154fdaa2189c425d1717c3a3b
        
        secret:
            cs_9c764fdd279f6325c0573fb0a5f633168b9d5735
         */
    }

    IEnumerator Product()
    {
        Debug.Log("Making an API call...");
        WWW www = new WWW(requestURL);
        yield return www;
        Debug.Log("Result of API call " + www.text);
        Debug.Log("Result of API call " + www.texture);
    }

 
}
