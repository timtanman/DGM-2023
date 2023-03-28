using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]


public class floatdata : ScriptableObject
{
    public float ammo;
    
    

    public void updatevalue(float num)
    {
        ammo += num;
        Debug.Log("Your ammunition increased to " + ammo);
    }

    public void reset(float num)
    {
        ammo = num;
        Debug.Log("Your current ammunition is " + num);
    }

    public void ammunition(float num)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ammo -= num;
            Debug.Log("Your ammunition is now " + ammo);
        }
    }
}
