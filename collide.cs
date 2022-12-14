using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.name ==("the name of the object you want collide"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
