using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggered : MonoBehaviour
{
       public DialogueM dMan;
       // Use this for initialization
       void Start()
       {
           dMan = FindObjectOfType<DialogueM>();
       }

       void OnTriggerExit2D(Collider2D collision)
       {
               gameObject.SetActive(false);
           
       }
}
