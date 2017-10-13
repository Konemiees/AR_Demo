using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowth : MonoBehaviour {

    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;

    private int treeCount;


    // Use this for initialization
    void Awake () {
        tree1.SetActive(true);
        tree2.SetActive(false);
        tree3.SetActive(false);
        tree4.SetActive(false);
        tree5.SetActive(false);
        treeCount = 1;
    }
	
	// Update is called once per frame
	public void ActionPressed () {
		if (treeCount == 1){
            tree2.SetActive(true);
            treeCount++;
        } else if (treeCount == 2){
            tree3.SetActive(true);
            treeCount++;
        }
        else if (treeCount == 3){
            tree4.SetActive(true);
            treeCount++;
        }
        else if(treeCount == 4){
            tree5.SetActive(true);
            treeCount++;
        }
        else{
            tree2.SetActive(false);
            tree3.SetActive(false);
            tree4.SetActive(false);
            tree5.SetActive(false);
            treeCount = 1;
        }
        
    }
}
