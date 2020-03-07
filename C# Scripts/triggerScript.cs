using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class triggerScript : MonoBehaviour
{
    public GameObject plane;
    public GameObject gameOver;
    public AudioSource crasher;
    public AudioClip crashSound;
    public GameObject wings;

    private void Start()
    {
        crasher = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over Cuh");
        crasher.clip = crashSound;
        crasher.Play();
        plane.SetActive(false);
        wings.SetActive(false);
        gameOver.SetActive(true);
        Time.timeScale = 0.3f;
        if (Time.timeScale < 0.4f) { 
            
            Invoke("nextScene", 1);
        }
    }
    public void nextScene()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
}
