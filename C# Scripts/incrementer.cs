using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class incrementer : MonoBehaviour
{
    public Text triggerCounter;
    public Animator anim;
    public AudioSource ringer;
    public ParticleSystem FX;
    public AudioClip ringSound;

    private void Start()
    {
        anim = triggerCounter.GetComponent<Animator>();
       
       
        
    }


    private void OnTriggerEnter(Collider other)
    {
        triggerCounter.GetComponent<scoreCounter>().counter++;
        anim.Play("ScoreAnim");
        Debug.Log("Entered");
        FX.Play();
        ringer = GetComponent<AudioSource>();
        ringer.clip = ringSound;
        ringer.Play();
        Debug.Log("sound");
        
    }
    private void OnTriggerExit(Collider other)
    {
        FX.Stop();
        ringer.Stop();
    }
}
