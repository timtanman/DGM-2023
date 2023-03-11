using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectparticleup : MonoBehaviour
{

    public int currentHP = 100;
    public SpriteRenderer spriteRenderer;
    public GameObject objectToDisable;
    public GameObject red;
    public GameObject blue;

    void Start()
    {


    }


    void Update()
    {

    }

    public void OnParticleCollision(GameObject other) {
            Debug.Log(currentHP);
            //currentHP -= 10;
            if (currentHP <= 20)
            {
                spriteRenderer.color = Color.red;
            }
            else if (currentHP <= 50)
            {
                spriteRenderer.color = Color.yellow;
            }
            else
            {
                spriteRenderer.color = Color.blue;
            }
            if (currentHP < 0)
        {
            objectToDisable.SetActive(false);
        }
        else
        {
            objectToDisable.SetActive(true);
        }
        if (other == red)
        {
            currentHP -= 10;
        }
        if (other == blue)
        {
            currentHP += 10;
        }
        }

}
