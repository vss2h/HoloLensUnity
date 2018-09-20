using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.down, 45*Time.deltaTime); /* Game Object revolves around a point in space.
	Needs arguments (point, axis of revolution, degrees/time).  
	Vector3.zero is shorthand for (0,0,0) and Vector3.up is (0,1,0) */
	}
}
