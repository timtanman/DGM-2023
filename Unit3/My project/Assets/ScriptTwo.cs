using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }

}
