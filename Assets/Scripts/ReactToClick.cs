using UnityEngine;
using System.Collections;

public class ReactToClick : MonoBehaviour {

    public enum ObjectType { Twitter, Cell, Landline, Newspaper};
    public ObjectType mType;

    public UIManager uiManager;


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

        switch (mType)
        {
            case ObjectType.Cell:
                uiManager.setCellphoneActive(true);
                break;
            case ObjectType.Twitter:
                uiManager.setTwitterActive(true);
                break;
            case ObjectType.Landline:
                uiManager.setLandlineActive(true);
                break;
            case ObjectType.Newspaper:
                uiManager.setNewspaperActive(true);
                break;
        }

        //uiManager.setNewspaperActive(true);


    }
}
