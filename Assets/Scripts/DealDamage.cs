using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour {

    // define the amount of damage done
    public int damage;
    // define a bool to check if this script will damage a player
    public bool damagePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        // check if a player enters the collider and this script damages the player
        if (damagePlayer && collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            // add -damage to the playerhealth
            collision.gameObject.GetComponent<PlayerHealth>().ModifyHealth(-damage);
        }
        // else if an enemy hits the collider
        else if (collision.gameObject.GetComponent<EnemyHealth>() != null)
		{
            // add -damage to the enemy health
			collision.gameObject.GetComponent<EnemyHealth>().ModifyHealth(-damage);
		}
    }
}
