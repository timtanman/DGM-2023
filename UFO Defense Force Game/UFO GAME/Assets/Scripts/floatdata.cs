using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]


public class floatdata : ScriptableObject
{
    public float powerlevel;
    public string new_gun;
    

    public void updatevalue(float num)
    {
        powerlevel += num;
        Debug.Log("Your ammunition increased to " + powerlevel);
    }

    public void reset(float num)
    {
        powerlevel = num;
        Debug.Log("Your current ammunition is " + num);
    }
}
