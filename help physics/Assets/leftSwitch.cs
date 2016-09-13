using UnityEngine;
using System.Collections;

public class leftSwitch : MonoBehaviour {

	Rigidbody RBBABY;

	// Use this for initialization
	void Start () {
		RBBABY = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		RBBABY.AddForce (Vector3.back * Input.GetAxis ("Horizontal"));
	}
}
