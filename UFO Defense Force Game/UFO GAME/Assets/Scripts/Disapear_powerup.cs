using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear_powerup : MonoBehaviour
{

    public float multiplier = 1.4f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PowerUp"))
            Destroy(other.gameObject);
        }
}
