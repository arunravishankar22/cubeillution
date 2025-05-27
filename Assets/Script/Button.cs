using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject Platform;
    public bool Moveable;
    public float speed, x, y, z;

    public Transform target;
    internal object onClick;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Moveable = true;
            button.transform.position= new Vector3(x,y,z);
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
