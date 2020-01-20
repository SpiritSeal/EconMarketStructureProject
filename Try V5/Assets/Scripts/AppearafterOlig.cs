using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearafterOlig : MonoBehaviour {
    public AreaManager aMan;
    public GameObject objectToActivate;
    // Use this for initialization
    void Start () {
        aMan = FindObjectOfType<AreaManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (aMan.activateSP)
        {
            objectToActivate.SetActive(true);
        }
	}
}
