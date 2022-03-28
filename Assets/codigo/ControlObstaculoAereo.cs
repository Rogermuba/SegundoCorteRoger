using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlObstaculoAereo : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "personaje")
        {
            Debug.Log ("Game Over");
            SceneManager.LoadScene ("Escena 1");

        }

    }
}
