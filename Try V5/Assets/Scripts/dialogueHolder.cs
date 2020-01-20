using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour {
    public string dialogue;
    private DialogueM dMan;
    public Transform thosObject;
    public string[] dialogueLines;
    public Transform currentObject;
    public GameObject instance;
    void Start () {
        dMan = FindObjectOfType<DialogueM>();
        thosObject = gameObject.transform;
        instance = gameObject;
    }
	
	// Update is called once per frame
    //remember that the OnTriggerEnter2D is actually supposed to be OnTriggerStay2D if using Space Bar thing
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name == "Male 1")
        {
            dMan.position = instance.transform;
            Debug.Log(instance.transform.position);
            currentObject = gameObject.transform;
            if (/*Input.GetKeyUp(KeyCode.Space)*/ true)
            {
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
            }
        }
	}
}
