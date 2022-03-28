using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlActivadorObstaculo : MonoBehaviour
{
    public GameObject activarTrampa;
    public Rigidbody piedra;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "personaje")
        {
            piedra.GetComponent<Rigidbody> ().useGravity = true;
            Debug.Log("funciona");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
