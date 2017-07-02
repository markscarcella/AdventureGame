using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    #region SINGLETON PATTERN
    public static GameManager _instance;
	public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("GameManager");
                    _instance = container.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }
    #endregion

    // Define player variable
    public PlayerMove player;
    // Degine Game UI variable
    public GameUI UI;
    // Define a list to keep track of player inventory
	public List<QuestItem> inventory;
	// Define the game canvases
	public Canvas menuCanvas;
    public Canvas winCanvas;
    public Canvas loseCanvas;
    // Define a variable to tell if the game is paused
	public bool isPaused;

	// Use this for initialization
	void Start () {
        // set up new inventory
		inventory = new List<QuestItem>();
        // turn on or off the interfaces
		UI.gameObject.SetActive(false);
		menuCanvas.enabled = true;
		winCanvas.enabled = false;
		loseCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Pause(bool state)
    {
        // set the pause state
        isPaused = state;
        // if paysed, stop physics
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        // else reset physics speed
        else
        {
            Time.timeScale = 1;
        }
    }

    public void EndGame(bool win)
    {
        // turn off the game UI and enable the menu


        // check if we've won
		if (win)
        {
            // enable win canvas


        }
        else
		{
            // enable lose canvas


		}
    }

    public void RestartGame()
    {
        // reload the current scene

    }

    public void StartGame()
    {
        // enable the game ui and disable all other canvases
		UI.gameObject.SetActive(true);
        menuCanvas.enabled = false;
        winCanvas.enabled = false;
		loseCanvas.enabled = false;
    }

    public void AddToInventory(QuestItem item)
    {
        // add the item to the inventory list
        inventory.Add(item);
        // if there are free slots in the inventory, add the item image to the sprite
        if (inventory.Count < UI.inventorySlots.GetComponentsInChildren<Image>().Length)
        {
            UI.inventorySlots.GetComponentsInChildren<Image>()[inventory.Count].sprite = item.inventoryImage;
        }
    }
}
