using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    // define the max health
	public float maxHealth;
    // define the current health
	public float health;
    // define a bool to check if this is a boss
    public bool isBoss;

	// Use this for initialization
	void Start () {
        // set the health to max
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ModifyHealth(int amt)
	{
        // add amt to health

        // if the health is less than zero
        if (isBoss && health <= 0)
        {
            // win the game

        }
	}
}
