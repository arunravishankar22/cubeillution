using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalbutton : MonoBehaviour
{
    public GameObject Platform;
    public bool Moveable;
    public float speed;

    public Transform target;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Moveable = true;
            level5.Moveable = false;
            movingplateform.automatic = true;
        }




    }

    private void Update()
    {
        if (Moveable)
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
