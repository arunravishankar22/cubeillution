using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrottat : MonoBehaviour
{
    public Camera cam;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            cam.transform.RotateAround(new Vector3(), new Vector3(x: 0, y: 0, z: 1), angle:180 );


        }
    }
}
