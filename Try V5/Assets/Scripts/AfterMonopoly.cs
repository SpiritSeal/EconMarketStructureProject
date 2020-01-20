using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterMonopoly : MonoBehaviour {
    public AreaManager aMan;
    public GameObject objectToActivateMon;
    // Use this for initialization
    void Start () {
        aMan = FindObjectOfType<AreaManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (aMan.done)
        {
            objectToActivateMon.SetActive(true);
        }
	}
}
