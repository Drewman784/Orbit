using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript1: MonoBehaviour
{
    public string Scenename;

    //call if level must be changed.
    void OnTriggerEnter2D (Collider2D other)
    {
        SceneManager.LoadScene(Scenename);
    }
}