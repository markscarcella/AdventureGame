using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // define the enemy waypoints
    public Vector3[] waypoints;
    // define the enemy move speed
    public int moveSpeed;
    // define an int to keep track of which waypoint we're up to
    int waypointIdx;

	// Use this for initialization
	void Start () {
        // set the position to the first waypoint 
        transform.position = waypoints[waypointIdx];
	}
	
	// Update is called once per frame
	void Update () {
        // move between the waypoints
		MoveBetweenWaypoints();
	}

    void MoveBetweenWaypoints()
    {
        // check if we've reached a waypoint
        if (transform.position != waypoints[waypointIdx])
        {
            // if not, move towards the waypoint at moveSpeed
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIdx], Time.deltaTime * moveSpeed);
        }
        else
        {
            // check if we've reached the end of the waypoints
			if (waypointIdx == waypoints.Length - 1)
			{
                // reset the index
				waypointIdx = 0;
			}
			else
			{
                // increase the index
				waypointIdx++;
			}
            // look at the next waypoint
            transform.LookAt(waypoints[waypointIdx]);
        }
    }
}
