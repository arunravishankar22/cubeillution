using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level5 : MonoBehaviour
{
    public GameObject button;
    public GameObject Platform;
    public static bool Moveable;
    public float speed, x, y, z;

    public Transform target;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Moveable = true;
            button.transform.position = new Vector3(x, y, z);
            movingplateform.automatic = true;
        }




    }

    private void Update()
    {
        if (Moveable == true)
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
