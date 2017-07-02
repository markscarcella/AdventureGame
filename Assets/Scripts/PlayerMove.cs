using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // define the move and jump speeds


    // define the player's rigidbody and the direction we will move
	Rigidbody rb;
    Vector3 direction;

	// Use this for initialization
	void Start () {
        // assign the rigidbody
        rb = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        // move the player

    }

    void MovePlayer()
    {
        // set the new direction to zero
		direction = Vector3.zero;

        // if we push a directio key, add to our direction vector
		if (Input.GetKey(KeyCode.UpArrow))
		{
			direction += new Vector3(1, 0, 1);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			direction += new Vector3(-1, 0, 1);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			direction += new Vector3(1, 0, -1);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			direction += new Vector3(-1, 0, -1);
		}

        // check if the new direction is not zero
		//if ()
		{
            // set player forward to be in the new direction

            // add to the player velocity in the forward direction

        }
    }


}
