using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private int sceneIndex;


    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextScene()
    {
        if(sceneIndex < SceneManager.sceneCountInBuildSettings -1){

            SceneManager.LoadScene(sceneIndex + 1);

        }
        else
        {
            Debug.Log("T'es un noob");
        }
    }
    
    public void LastScene()
    {
        if(sceneIndex > 0){

            SceneManager.LoadScene(sceneIndex - 1);

        }
        else
        {
            Debug.Log("T'es un noob");
        }
    }

}
