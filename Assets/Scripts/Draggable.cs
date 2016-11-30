using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();

        //remove from parent
        this.transform.SetParent(this.transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        //can keep track of starting mouse offset to make sure that the picture doesn't do that jump thing
        this.transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // throw new NotImplementedException();
    }
}
