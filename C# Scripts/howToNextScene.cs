using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howToNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("goBack", 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void goBack()
    {
        SceneManager.LoadScene("HelloVR");
    }
}
