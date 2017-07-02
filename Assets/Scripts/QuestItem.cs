using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour {

    // define the inventory image sprite
    public Sprite inventoryImage;
    // define the associated quest
    public Quest associatedQuest;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        // if the player enters the trigger
        if (other.tag == "Player")
        {
            // add the item to the inventory
            GameManager.Instance.AddToInventory(this);
            // set the quest item to true
            associatedQuest.hasQuestItem = true;
            // destroy the game object
            Destroy(gameObject);
        }
    }
}
