using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {

    //public Input BatteryStatus = Input.GetKeyUp(KeyCode.UpArrow);

    public Camera overheadCam;
    public Camera closeCam;
    public Camera closeCam2;

    // Use this for initialization

     void Start ()
    {
        overheadCam.enabled = true;
        closeCam.enabled = false;
        closeCam2.enabled = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            overheadCam.enabled = false;
            closeCam.enabled = true;
            closeCam2.enabled = false;
        }
            
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            overheadCam.enabled = false;
            closeCam.enabled = false;
            closeCam2.enabled = true;
        }
            //ShowCloseCam1();
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            overheadCam.enabled = true;
            closeCam.enabled = false;
            closeCam2.enabled = false;
        }
         
    }
}
