using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRange;
    public float zRange;
    public float num;

    public Transform blaster;
    public GameObject Bullet;
    public Transform blaster2;
    public GameObject Bullet2;
    public GameManager gameManager;
    

    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z <= -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }



        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, blaster.transform.position, Bullet.transform.rotation);
            //Instantiate(Bullet2, blaster2.transform.position, Bullet2.transform.rotation);
        }


    }
}
