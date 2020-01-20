﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueM : MonoBehaviour
{
    public Transform position;
    public GameObject dBox;
    public Text dText;
    public bool dialogueActive;

    public string[] dialogueLines;
    public int currentLine;

    public int FM_PeopleTalkedTo;
    public int MC_PeopleTalkedTo;
    public int Ol_PeopleTalkedTo;
    public int M_PeopleTalkedTo;

    void Update()
    {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogueActive = false;
            currentLine++;
        }

        if(currentLine>= dialogueLines.Length)
        {
            dBox.SetActive(false);
            dialogueActive = false;

            currentLine = 0;
        }

        dText.text = dialogueLines[currentLine];
    }
    public void ShowBox(string dialogue)
    {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogueActive = true;
        dBox.SetActive(true);
    }
}