using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPtriggered : MonoBehaviour {
    public AreaManager aMan;
    public GameObject SP_Event;
	// Use this for initialization
	void Start () {
        aMan = FindObjectOfType<AreaManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if (aMan.activateSP)
        {
            SP_Event.SetActive(true);
        }
        else
        {
            SP_Event.SetActive(false);
        }
	}
}
