using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeText : MonoBehaviour
{
    public Text timer;
    private string time;
    private float rounder;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        rounder = Mathf.Round(Time.time * 100.0f) * 0.01f;
        time = rounder.ToString();
        timer.text = time + "s";
       
    }
}
