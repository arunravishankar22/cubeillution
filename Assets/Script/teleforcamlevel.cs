using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleforcamlevel : MonoBehaviour
{
    public GameObject player, portal;
    public Camera camera;
    public float horiFROM, horiTO, verFROM, verTO;


    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&
            ((camera.transform.eulerAngles.x >= horiFROM) && (camera.transform.eulerAngles.x <= horiTO))/*&&
            ((camera.transform.eulerAngles.y > -46f) && (camera.transform.eulerAngles.y < -44f))*/)
        {
            Debug.Log("yes");
            StartCoroutine(teleport());
        }
    }


    IEnumerator teleport()
    {
        yield return new WaitForSeconds(0.01f);
        player.transform.position = new Vector3(portal.transform.position.x, portal.transform.position.y, portal.transform.position.z);

    }
}
