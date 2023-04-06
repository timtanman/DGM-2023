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
    public Match_Behavior matchBehavior;

    public void Start()
    {
        cameraObj = Camera.main;
        matchBehavior = GetComponent<Match_Behavior>();
        matchBehavior.noMatchEvent.AddListener(DisableDragging);
        matchBehavior.matchEvent.AddListener(EnableDragging);

    }

    public void OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
        startDragEvent.Invoke();
    }

    public void OnMouseUp()
    {
        isDragging = false;
        endDragEvent.Invoke();
    }

    public void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }
    
    public void DisableDragging()
    {
        isDragging = false;
        transform.position = new Vector3(transform.position.x, 315f, transform.position.z);
    }

    public void EnableDragging()
    {
        isDragging = true;
    }
}



