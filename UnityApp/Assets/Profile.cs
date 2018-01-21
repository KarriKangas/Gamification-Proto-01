using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Profile : MonoBehaviour {
    public GameObject expLvl;
    public GameObject expBar;

    int requiredExp;
	float fill;
    Data Data;
    // Use this for initialization
    void Start () {
        Data = GameObject.Find("Data").GetComponent<Data>();

    }
	
	// Update is called once per frame
	void Update () {
		expLvl.GetComponent<Text>().text = "Experience: " + Data.experience + "\nLevel: " + Data.level + "\nScans: " + Data.scans ;
		fill = ((float)Data.experience/(float)Data.requiredExp);
		expBar.GetComponent<Image> ().fillAmount = fill;

    }
}
