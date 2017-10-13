using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour {

    public GameObject target;

    //private bool leftPressed;
    //private bool rightPressed;

	// Use this for initialization
	void Start () {
        //leftPressed = false;
        //rightPressed = false;
	}
	
	// Update is called once per frame
	void turn (int dir) {
        Vector3 oldRot = target.transform.rotation.eulerAngles;

    }
}
