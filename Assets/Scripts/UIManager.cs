using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public Canvas newspaperCanvas;
    public Canvas twitterCanvas;
    public Canvas landlineCanvas;
    public Canvas cellphoneCanvas;

    // Use this for initialization
    void Start () {
        //hide the UI
        //newspaperCanvas.SetActive(false);
        newspaperCanvas.gameObject.SetActive(false);
        twitterCanvas.gameObject.SetActive(false);
        landlineCanvas.gameObject.SetActive(false);
        cellphoneCanvas.gameObject.SetActive(false);
    }

    public void closeUI()
    {
        //hide the UI
        newspaperCanvas.gameObject.SetActive(false);
        twitterCanvas.gameObject.SetActive(false);
        landlineCanvas.gameObject.SetActive(false);
        cellphoneCanvas.gameObject.SetActive(false);
    }

    public void setNewspaperActive(bool val)
    {
        newspaperCanvas.gameObject.SetActive(val);
    }

    public void setTwitterActive(bool val)
    {
        twitterCanvas.gameObject.SetActive(val);
    }

    public void setLandlineActive(bool val)
    {
        landlineCanvas.gameObject.SetActive(val);
    }

    public void setCellphoneActive(bool val)
    {
        cellphoneCanvas.gameObject.SetActive(val);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
