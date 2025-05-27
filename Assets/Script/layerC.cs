using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerC : MonoBehaviour
{
    public GameObject gameObject;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            gameObject.layer = 6;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            gameObject.layer = 6;

        }
    }
}
