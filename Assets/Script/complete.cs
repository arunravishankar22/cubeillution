using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class complete : MonoBehaviour
{
    public static int nextScene = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(next());
    }

    IEnumerator next()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(nextScene);
    }
}
