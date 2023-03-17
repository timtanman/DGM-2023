using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_spawn : MonoBehaviour
{

    public Transform spawner;
    public GameObject Powerup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Powerup, spawner.transform.position, Powerup.transform.rotation);
        }
    }
}
