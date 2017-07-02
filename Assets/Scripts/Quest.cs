using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {

    // define a canvas to show the alert symbol
    public Canvas alertCanvas;
    // define a string array for the quest instructions
	[TextArea(3, 10)]
	public string[] instructionDialogue;
    // define a string array for the quest complete dialogue
	[TextArea(3, 10)]
    public string[] completeDialogue;

    // define an audio clip to play
    public AudioClip audioClip;
    // define a bool to check if the player has collected the quest item
    public bool hasQuestItem;
    // define a bool to check if the quest is complete
    public bool complete;
    // define a variable to say how much power is added upon completion
    public int powerAdded;

    // define the audio source
    AudioSource audioSource;


	// Use this for initialization
	void Start () {
        // disable alert canvas
        alertCanvas.enabled = false;
        // assign the audio source
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        // if the player enters the trigger
        if (other.tag == "Player")
        {
            // enable the alert canvas
            alertCanvas.enabled = true;
        }
    }

	private void OnTriggerStay(Collider other)
	{
        // if the player is in the trigger and pushes X
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.X))
        {
            // play audio clip
            audioSource.PlayOneShot(audioClip);
            // open the UI dialogue box
            GameManager.Instance.UI.showingDialogue = true;
            // check if the quest item is collected but the quest isn't complete
            if (hasQuestItem && !complete)
			{
				// set the quest to complete
				complete = true;
                // set the dialogue pages to the complete dialogue
				GameManager.Instance.UI.dialoguePages = completeDialogue;
                // add power to the player magic
                // NB. You can instead add points or other modifiers here as a prize
                // instead for finishing the quest
                other.GetComponent<PlayerMagic>().ModifyPower(powerAdded);
			}
            // if the player doesn't have the item
            else
            {
                // display the quest instructions
				GameManager.Instance.UI.dialoguePages = instructionDialogue;
			}

		}
	}

	private void OnTriggerExit(Collider other)
	{
        // if the player leaves the trigger
		if (other.tag == "Player")
		{
            // disable the alert canvas
            alertCanvas.enabled = false;
		}
	}
}
