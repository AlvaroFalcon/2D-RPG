using UnityEngine;
using System.Collections;

public class DialogHolder : MonoBehaviour {

	public string[] dialogueLines;
	public string dialogue;
	private DialogueManager dialogManager;

	void Start () {
		dialogManager = FindObjectOfType<DialogueManager> ();
	
	}

	void OnTriggerStay2D(Collider2D other){
		
		if(other.gameObject.name == "Player"){
			
			if(Input.GetKeyUp(KeyCode.F)){
				
				if (!dialogManager.dialogActive) {
					
					dialogManager.dialogLines = dialogueLines;
					dialogManager.currentLines = 0;
					dialogManager.ShowDialogue ();
				}
			}

		}
	}
}
