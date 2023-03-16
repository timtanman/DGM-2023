using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_bullet : MonoBehaviour
{

    public float speed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
