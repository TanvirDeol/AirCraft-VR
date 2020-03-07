using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtScript : MonoBehaviour
{
    public GameObject plane;
    public Text distance;
    private string coord;
    private int dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.RoundToInt(plane.transform.position.z);
        coord = dist.ToString();
        distance.text =  coord + "m";
       
    }

}
