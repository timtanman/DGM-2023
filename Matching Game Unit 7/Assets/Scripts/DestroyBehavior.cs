using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsObj;

    public void callDestroyTimer() 
    {
        StartCoroutine(DestroyTimer());
    }


    IEnumerator DestroyTimer()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
        
    }

    

}
