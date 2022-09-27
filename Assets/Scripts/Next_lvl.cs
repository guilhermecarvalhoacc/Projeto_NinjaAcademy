using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Next_lvl : MonoBehaviour
{
    public string level;

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("hit detected");
        SceneManager.LoadScene(level);
    }
}
