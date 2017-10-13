using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FaceCamera : MonoBehaviour {


    public GameObject arcamera;

	// Update is called once per frame
	void Update () {
        transform.LookAt(arcamera.transform);
	}
}
