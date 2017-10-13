using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScript : MonoBehaviour {

    Animator animus;

	// Use this for initialization
	void Start () {
        animus = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void ActionPressed () {
        animus.SetTrigger("Action");
	}
}
