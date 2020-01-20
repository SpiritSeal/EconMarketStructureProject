using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    //sets the scale factor for the camera
    public float Scale;
    //gets the Dialogue Manage Items
    private DialogueM dMan;
    //gets the dialogue holders
    public Transform[] DialH;
    //gets the player
    public GameObject Male1;
    //temp variable
    public GameObject[] InBetween;
    //gets the Warp Script and it's components
    private dialogueHolder dHol;
    //the Camera, duh
    Camera mycam;




    // Use this for initialization
    void Start () {
        mycam = GetComponent<Camera>();
        dMan = FindObjectOfType<DialogueM>();
        dHol = FindObjectOfType<dialogueHolder>();
        InBetween = GameObject.FindGameObjectsWithTag("Dialogue Holder");
        Transform[] DialH = InBetween.Select(f => f.transform).ToArray();

    }

	// Update is called once per frame
	void Update () {
        
        if (dMan.dialogueActive)
        {
            target = dMan.position.transform;
        } 
        else
        {
            target = Male1.transform;
        }  
        mycam.orthographicSize = (Screen.height / 100f) / (1/Scale);
        if(target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
        }
	}
}
