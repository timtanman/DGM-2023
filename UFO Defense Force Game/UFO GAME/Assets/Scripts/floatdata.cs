using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]


public class floatdata : ScriptableObject
{
    public float ammo;
    public string new_gun;
    public Transform blaster;
    public GameObject Bullet;
    

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
    public void startstopammo(float num)
    {
        if(Input.GetKeyDown(KeyCode.Space) && num > 0)
        {
            Instantiate(Bullet, blaster.transform.position, Bullet.transform.rotation);
        }
    }
}
