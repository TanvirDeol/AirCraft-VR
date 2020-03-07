using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public int counter = 0;
    public Text triggerCounter;
    private string amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //counter *= 50;
        amount = counter.ToString();
        triggerCounter.text = amount + "00";
    }
}
