using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DropZone : MonoBehaviour, IDropHandler {

    public void OnDrop(PointerEventData eventData)
    {
        //throw new NotImplementedException();

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }

    
}
