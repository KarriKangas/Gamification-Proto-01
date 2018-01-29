using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {
    public int latestExpGain;
    public int experience;
    public int level;
    public int requiredExp;
	public int scans;
    float expFactor;
	public string currentScanID;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start () {
		scans = 0;
        expFactor = 1.5f;
        experience = 0;
        level = 1;
        calculateExpReq();
    }
	
	// Update is called once per frame
	void Update () {
		if (experience > requiredExp) {
			level++;
			experience = 0;
			calculateExpReq ();
		}

	}

    void calculateExpReq()
    {
        float expReq;
        expReq = 10 * Mathf.Pow(level , expFactor);
        requiredExp = (int)expReq;

    }
}
