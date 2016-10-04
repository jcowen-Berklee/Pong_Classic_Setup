//LMSC-281 Logic and Programming
//example ball startup script that uses the physics system
//Fall 2016 Jeanine Cowen

using UnityEngine;
using System.Collections;

public class ballDynamic : MonoBehaviour {

	//this will hold the rigidbody component of the object, so that it can then be adjusted by the physics engine
	public Rigidbody rb;

	//this is not truly necessary, just used to give the object a known direction when the script is initialized
	public GameObject targetObject;

	//a variable to control the force applied to the ball
	float ballForce = 10.0f;


	void Start() {

		//this loads the rigidbody component of the object to which this script is applied
		rb = GetComponent<Rigidbody>();

		//this rotates the object toward a defined location, drag an object in the inspector onto the targetObject field
		transform.LookAt (targetObject.transform);
	}
		
	//FixedUpdate is the proper function to place all physics updates
	void FixedUpdate() {

		//now that the object is faced toward a target apply a force and move it forward
		rb.AddForce(transform.forward * ballForce);
	}

}
