using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaManager : MonoBehaviour {
    public int AreaCode = 7;
    public Text aText;
    public bool visitedPC = false;
    public bool visitedMC = false;
    public bool visitedOL = false;
    public bool activateSP = false;
    public bool done = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(AreaCode == 0)
        {
            aText.text = "The Beginning";
        }
        if(AreaCode == 1)
        {
            aText.text = "Perfect Competition";
            visitedPC = true;
        }
        if (AreaCode == 2)
        {
            aText.text = "Monopolistic Competition";
            visitedMC = true;
        }
        if (AreaCode == 3)
        {
            aText.text = "Oligopoly";
            visitedOL = true;
        }
        if (AreaCode == 4)
        {
            aText.text = "OverSimplified Market Structures Central";
        }
        if (AreaCode == 5)
        {
            aText.text = "Monopoly";
        }
        if (AreaCode == 6)
        {
            aText.text = "Construction";
        }
        if (AreaCode == 7)
        {
            aText.text = "Home";
        }
        if (AreaCode == 8)
        {
            aText.text = "Something Blew up...";
        }
        if (AreaCode == 10)
        {
            aText.text = "Secret Passageway";
        }
        if (AreaCode == 9)
        {
            aText.text = "The Monopoly";
            done = true;
        }
        if (visitedMC && visitedOL && visitedPC)
        {
            activateSP = true;
            Debug.Log("SP init");
        }
    }
}
