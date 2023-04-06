using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    private bool isDragging = false;
    private Vector3 offset;
    public UnityEvent startDragEvent, endDragEvent;

    void Start()
    {
        cameraObj = Camera.main;
    }

    void OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
        startDragEvent.Invoke();
    }

    void OnMouseUp()
    {
        isDragging = false;
        endDragEvent.Invoke();
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }
}



