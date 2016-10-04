﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour {

	public GameObject dialogueBox;
	public Text dialogueText;
	public bool dialogActive;
	public string[] dialogLines;
	public int currentLines;

	void Start(){
		currentLines = 0;
	}
	void Update () {
		
		if (dialogActive && Input.GetKeyDown(KeyCode.Space)) {
			currentLines++;
		}

		if(currentLines >= dialogLines.Length){
			dialogueBox.SetActive (false);
			dialogActive = false;
			currentLines = 0;
		}
		dialogueText.text = dialogLines [currentLines];
	}
	public void ShowDialogue(){
		
		dialogActive = true;
		dialogueBox.SetActive (true);
	}

}
