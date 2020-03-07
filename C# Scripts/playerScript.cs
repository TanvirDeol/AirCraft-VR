using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject capper;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }
    private void Update()
    {
       
    }
}
