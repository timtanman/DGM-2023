using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{

    public GameObject Cayde;
    public GameObject Titan;
    public float speed;


    void Update()
    {
        Cayde.transform.position = Vector3.MoveTowards(Cayde.transform.position, Titan.transform.position, speed);
    }
}
