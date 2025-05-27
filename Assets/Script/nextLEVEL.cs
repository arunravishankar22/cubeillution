using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLEVEL : MonoBehaviour
{
   
    public GameObject CompleteUI;
    public int NextScene;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //complete.nextScene++;
            StartCoroutine(comp());


        }
        
    }

    private void Update()
    {
        
    }

    IEnumerator comp()
    {
        yield return new WaitForSeconds(1);
        CompleteUI.SetActive(true);
        StartCoroutine(next());
    }

    IEnumerator next()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(NextScene);
    }
}
