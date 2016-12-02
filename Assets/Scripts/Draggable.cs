using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        parentToReturnTo = this.transform.parent;

        //remove from parent
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //can keep track of starting mouse offset to make sure that the picture doesn't do that jump thing
        this.transform.position = eventData.position;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // throw new NotImplementedException();
        //this.transform.parent = parentToReturnTo;
        this.transform.SetParent(parentToReturnTo);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
