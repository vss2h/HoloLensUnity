using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 3*Time.deltaTime, 0); /* Game Object rotates 0 degrees about the x axis, 3 degrees * change in game time about
	the y-axis, and 0 degrees about the x axis */
	}
}
