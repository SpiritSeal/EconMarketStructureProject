using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterOlig : MonoBehaviour {
    public ComingFromOlig CFO;
	// Use this for initialization
	void Start () {
        CFO = FindObjectOfType<ComingFromOlig>();
	}
	
	// Update is called once per frame
	void Update () {
        if (CFO.OligDone)
        {
            gameObject.SetActive(false);
        }
	}
}
