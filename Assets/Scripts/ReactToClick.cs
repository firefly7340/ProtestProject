﻿using UnityEngine;
using System.Collections;

public class ReactToClick : MonoBehaviour {

    public GameObject UICanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        print("Box Clicked!");

        //display newspaper UI with button to close
        UICanvas.SetActive(true);

    }
}