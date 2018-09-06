using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Transform target;
	// Update is called once per frame
	void Update ()
    {

        transform.LookAt(target); // has a Game Object continually face another Game Object (target)	
	}
}
