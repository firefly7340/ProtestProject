using UnityEngine;
using System.Collections;

public class ReactToClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("mouse 0"))
        {
            //print("hello world");
        }
	}

    void OnMouseDown()
    {
        print("Box Clicked!");
    }
}
