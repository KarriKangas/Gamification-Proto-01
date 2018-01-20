using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChanger : MonoBehaviour {

    public void OnClickScanner()
    {
        string n = "ScannerPart";
        Debug.Log("WHAT LOADED? " + n);
        SceneManager.LoadScene(n);
    }

    public void OnClickMain()
    {
        string n = "Boot";
        Debug.Log("WHAT LOADED? " + n);
        SceneManager.LoadScene(n);
    }

    public void OnClickProfile()
    {
        string n = "Profile";
        Debug.Log("WHAT LOADED? " + n);
        SceneManager.LoadScene(n);
    }

    public void OnClickProduct()
    {
        string n = "ProductPage";
        Debug.Log("WHAT LOADED? " + n);
        SceneManager.LoadScene(n);
    }

    public void OnClickAbout()
    {
        string n = "About";
        Debug.Log("WHAT LOADED? " + n);
        SceneManager.LoadScene(n);
    }
}
