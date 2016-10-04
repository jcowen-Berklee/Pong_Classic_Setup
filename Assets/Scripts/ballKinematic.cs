//LMSC-281 Logic and Programming
//example ball startup script which uses the transform.Translate set of Kinematic functions
//Fall 2016 Jeanine Cowen

using UnityEngine;
using System.Collections;

public class ballKinematic : MonoBehaviour {

	//a variable to control the speed of the ball
	float ballSpeed = 5.0f;


	void Start() {
	
	}


	void Update () {

		//we are using the transform component to move the object, there are many more options that can be found here:
		//http://docs.unity3d.com/ScriptReference/Transform.Translate.html
		//http://docs.unity3d.com/ScriptReference/Vector3.html

		//also note the use of a time function/method
		//http://docs.unity3d.com/ScriptReference/Time-deltaTime.html

//		transform.Translate(Vector2.left * ballSpeed*Time.deltaTime);
		transform.Translate (new Vector2(-0.5f, -0.5f)* ballSpeed*Time.deltaTime);
	}

}