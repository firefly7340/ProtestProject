using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject UICanvas;

	// Use this for initialization
	void Start () {
        //hide the UI
        UICanvas.SetActive(false);
	}

    public void closeUI()
    {
        //hide the UI
        UICanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
