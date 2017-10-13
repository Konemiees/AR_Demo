using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour {

    public GameObject instructionCanvas;

    void Start(){
        instructionCanvas.SetActive(false);
    }

    public void Instructions()
    {
        instructionCanvas.SetActive(true);
    }

    public void BackButton()
    {
        instructionCanvas.SetActive(false);
    }
}
