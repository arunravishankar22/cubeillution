using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (grty.change == false)
            {
                grty.change = true;
                
            }
            else
            {
              
                grty.change = false;
            }
        }
    }
    
}
