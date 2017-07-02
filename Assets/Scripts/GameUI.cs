using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    // define health and power bars
    public Slider healthBar;
    public Slider powerBar;
    // define text box image and text box
    public Image textBoxImage;
    public Text textBox;
    // define the inventory slots
    public LayoutGroup inventorySlots;
    // define a bool to check if we're showing dialogue
	public bool showingDialogue;
    // define an array of strings to hold the pages of dialogue
	public string[] dialoguePages;
    // define an int to keep track of which page we're up to
	int pageIdx;

	// Use this for initialization
	void Start () {
        // close all dialogue boxes
		CloseDialogue();
	}
	
	// Update is called once per frame
	void Update () {     
        // check if we are showing dialogue
		if (showingDialogue)
		{
            // check if the action key is pressed
			if (Input.GetKeyDown(KeyCode.X))
			{
                // if the page index is less than the total number of pages
				if (pageIdx < dialoguePages.Length)
				{
                    // open the page
					OpenDialogue(dialoguePages[pageIdx]);
                    // move to the next page
					pageIdx++;
				}
				else
                {
                    // close the dialogue
					CloseDialogue();
                    // reset page index
                    pageIdx = 0;
				}
			}
		}
	}

    public void OpenDialogue(string text)
    {        
        // enable the text box and image
		textBoxImage.enabled = true;
		textBox.enabled = true;
        // set the text
		textBox.text = text;
        // pause the game
		GameManager.Instance.Pause(true);
	}

    public void CloseDialogue()
    {
        // no longer show dialogue
		showingDialogue = false;
        // disable text box and image
		textBoxImage.enabled = false;
        textBox.enabled = false;
        // reset the dialogue pages to empty
        dialoguePages = new string[0];
        // unpause the game
        GameManager.Instance.Pause(false);
    }
}
