using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    // define the max health
	public float maxHealth;
    // define the current health
	public float health;

	// Use this for initialization
	void Start () {
        // set the health to be max    
		health = maxHealth;
        // set the healthbar max value
		GameManager.Instance.UI.healthBar.maxValue = maxHealth;
        // set the healthbar current value
		GameManager.Instance.UI.healthBar.value = health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ModifyHealth(int amt)
	{
        // add amt to the health

        // modify the healthbar

        // if the health is less than zero
        if (health <= 0)
        {
            // lose the game

        }
	}
}
