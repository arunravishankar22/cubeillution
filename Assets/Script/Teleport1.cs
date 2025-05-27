using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public GameObject player,portal;

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag=="Player")
        {
            StartCoroutine(teleport());
        }
    }


    IEnumerator teleport()
    {
        yield return new WaitForSeconds(0.01f);
        player.transform.position = new Vector3(portal.transform.position.x, portal.transform.position.y, portal.transform.position.z);

    }

}
//thePlayer.transform.position = Vector3.MoveTowards(thePlayer.transform.position, teleportpoint.position,  * Time.deltaTime);