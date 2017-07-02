using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // define the camera distance and size
	public float cameraDistance;
	public float cameraSize;

	// Use this for initialization
	void Start () {
        // assign the camera size
		Camera.main.orthographicSize = cameraSize;
	}
	
	// Update is called once per frame
	void Update () {
        // check that the player exists
        if (GameManager.Instance.player != null)
        {
            // Make camera follow the player at defined distance       
            Camera.main.transform.position = GameManager.Instance.player.transform.position - Camera.main.transform.forward * cameraDistance;
        }
	}
}
