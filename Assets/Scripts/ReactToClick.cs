using UnityEngine;
using System.Collections;

public class ReactToClick : MonoBehaviour {

    public enum ObjectType { Twitter, Cell, Landline, Newspaper};
    public ObjectType mType;

    public UIManager uiManager;

    void OnMouseDown()
    {
        //print("Box Clicked!");

        //display newspaper UI with button to close

        switch (mType)
        {
            case ObjectType.Cell:
                uiManager.activateCellphone();
                break;
            case ObjectType.Twitter:
                uiManager.activateTwitter();
                break;
            case ObjectType.Landline:
                uiManager.activateLandline();
                break;
            case ObjectType.Newspaper:
                uiManager.activateNewspaper();
                break;
        }

        //uiManager.setNewspaperActive(true);


    }
}
