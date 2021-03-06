﻿using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public Canvas newspaperCanvas;
    public Canvas twitterCanvas;
    public Canvas landlineCanvas;
    public Canvas cellphoneCanvas;
    public Canvas officerAssignCanvas;
    public Canvas dialogueCanvas;

    private Dialogue mDialogue;

    //bool inUse = true;

    // Use this for initialization
    void Start () {
        //hide the UI
        //newspaperCanvas.SetActive(false);
        newspaperCanvas.gameObject.SetActive(false);
        twitterCanvas.gameObject.SetActive(false);
        landlineCanvas.gameObject.SetActive(false);
        cellphoneCanvas.gameObject.SetActive(false);
        officerAssignCanvas.gameObject.SetActive(false);
        dialogueCanvas.gameObject.SetActive(false);

        mDialogue = dialogueCanvas.GetComponent<Dialogue>();
    }

    public void addDialogue(string message)
    {
        //print("got messages to add " + message);
        //print("adding message " + message);
        mDialogue.addMessage(message);
        dialogueCanvas.gameObject.SetActive(true);
    }

    private bool inUse()
    {
        //return newspaperCanvas.gameObject.active;
        return newspaperCanvas.isActiveAndEnabled || twitterCanvas.isActiveAndEnabled ||
            landlineCanvas.isActiveAndEnabled || cellphoneCanvas.isActiveAndEnabled
            || officerAssignCanvas.isActiveAndEnabled || dialogueCanvas.isActiveAndEnabled;
    }



    public void closeUI()
    {
        //inUse = false;
        //hide the UI
        newspaperCanvas.gameObject.SetActive(false);
        twitterCanvas.gameObject.SetActive(false);
        landlineCanvas.gameObject.SetActive(false);
        cellphoneCanvas.gameObject.SetActive(false);
        officerAssignCanvas.gameObject.SetActive(false);
    }


    public void activateNewspaper()
    {
        if (!inUse())
        {
            newspaperCanvas.gameObject.SetActive(true);
            //inUse = true;
        }
    }
    public void deactivateNewspaper()
    {
        newspaperCanvas.gameObject.SetActive(false);
        //inUse = false;
    }


    public void activateTwitter()
    {
        if (!inUse())
        {
            twitterCanvas.gameObject.SetActive(true);
            //inUse = true;
        }
    }
    public void deactivateTwitter()
    {
        twitterCanvas.gameObject.SetActive(false);
        //inUse = false;
    }


    public void activateLandline()
    {
        if (!inUse())
        {
            landlineCanvas.gameObject.SetActive(true);
            //inUse = true;
        }
    }
    public void deactivateLandline()
    {
        landlineCanvas.gameObject.SetActive(true);
        //inUse = true;
    }


    public void activateCellphone()
    {
        if (!inUse())
        {
            cellphoneCanvas.gameObject.SetActive(true);
            //inUse = true;
        }
    }
    public void deactivateCellphone()
    {
        cellphoneCanvas.gameObject.SetActive(true);
        //inUse = true;
    }


    public void activateOfficerAssign()
    {
        if (!inUse())
        {
            officerAssignCanvas.gameObject.SetActive(true);
            //inUse = true;
        }
    }
    public void deactivateOfficerAssign()
    {
        officerAssignCanvas.gameObject.SetActive(true);
        //inUse = true;
    }


    
    public void setNewspaperActive(bool val)
    {
        
        newspaperCanvas.gameObject.SetActive(val);
        //inUse = val;
    }

    public void setTwitterActive(bool val)
    {
        twitterCanvas.gameObject.SetActive(val);
        //inUse = val;
    }

    public void setLandlineActive(bool val)
    {
        landlineCanvas.gameObject.SetActive(val);
        //inUse = val;
    }

    public void setCellphoneActive(bool val)
    {
        cellphoneCanvas.gameObject.SetActive(val);
        //inUse = val;
    }

    public void setOfficerAssignActive(bool val)
    {
        officerAssignCanvas.gameObject.SetActive(val);
        //inUse = val;
    }

}
