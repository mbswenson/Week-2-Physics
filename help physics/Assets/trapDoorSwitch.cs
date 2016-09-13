using UnityEngine;
using System.Collections;

public class trapDoorSwitch : MonoBehaviour {
	float rotationSpeed = -2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// if I hit a specific key, open the trap door
		if (Input.GetKey (KeyCode.T)) {
			print ("open trapdoor");
	    // rotate z to -90 degrees
			transform.Rotate (Vector3.forward * rotationSpeed );
		}
	  }
	}
