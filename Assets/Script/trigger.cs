using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject platform;
    public Transform target, reset;
    public bool move;
    public float speed;

    private void Start()
    {

        move = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (move)
                move = false;
            else
                move = true;
        }
        
    }

    private void Update()
    {
        if (move)
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, target.position, speed * Time.deltaTime);
        else
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, reset.position, speed * Time.deltaTime); ;
    }
}
