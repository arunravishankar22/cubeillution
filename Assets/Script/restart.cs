using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public int scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Object")
            Physics.gravity = new Vector3(0f, -9.81f, 0f);
        SceneManager.LoadScene(scene);
    }

}
