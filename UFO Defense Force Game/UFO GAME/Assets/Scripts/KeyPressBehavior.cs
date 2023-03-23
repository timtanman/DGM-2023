using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPressBehavior : MonoBehaviour
{
    public UnityEvent onKeyPress;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onKeyPress.Invoke();
        }
    }
}
