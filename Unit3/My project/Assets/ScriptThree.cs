using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground! And probably will die soon after...");
        }
    }

}
