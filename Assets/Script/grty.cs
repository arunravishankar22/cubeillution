using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grty : MonoBehaviour
{
    public static bool change;
   
    void Start()
    {
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            Physics.gravity = new Vector3(0f, 9.81f, 0f);
            Debug.Log("yes");
        }
        else
        {
            Physics.gravity = new Vector3(0f,-9.81f, 0f);
            Debug.Log("No");

        }
    }
}
