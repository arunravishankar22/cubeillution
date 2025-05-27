using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Rigidbody rigidbody;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            Physics.gravity= new Vector3(0f, 9.81f, 0f);
            
           
        }

        rigidbody.useGravity = false;
    }
    
}
