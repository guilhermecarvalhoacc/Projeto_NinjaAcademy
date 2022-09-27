using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{

    public void Next()
    {

        Debug.Log("click detected");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
