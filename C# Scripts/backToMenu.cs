using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("backToStart", 2);
    }

    // Update is called once per frame
   public void backToStart()
    {
        SceneManager.LoadScene(0);
    }
}
