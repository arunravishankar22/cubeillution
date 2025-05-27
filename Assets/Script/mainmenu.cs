using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    //public int scene;
    //public void playGame()
    //{
    //        SceneManager.LoadScene(scene);
    //}

    public void exit()
    {
        Application.Quit();
    }

    public void mainmanu()
    {
        SceneManager.LoadScene(0);
    }


    public GameObject CompleteUI;
    

   public void playButton()
    {
        //StartCoroutine(comp());
        CompleteUI.SetActive(true);
    }

    private void Update()
    {
       
    }

    //IEnumerator comp()
    //{
    //    yield return new WaitForSeconds(1);
    //    CompleteUI.SetActive(true);
        
    //}

    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    public void Level4()
    {
        SceneManager.LoadScene(4);
    }
    public void Level5()
    {
        SceneManager.LoadScene(5);
    }
    public void Level6()
    {
        SceneManager.LoadScene(6);
    }
}
