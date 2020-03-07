using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteScript : MonoBehaviour
{
    public Transform movePos;
    public GameObject levelBlock, levelBlock2;
    public GameObject player;
    Vector3 inFront;
    GameObject copy;
    bool creator = false;
    public Transform levelRot, levelRot2;
    public GameObject cam;
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inFront = new Vector3(0, 0, player.transform.position.z + 75);
        
        //Debug.Log(player.transform.position.z);

        for (i = 0; i < 1000; i++)
        {
            int increment = i *50 ;

            
            if (player.transform.position.z > increment && player.transform.position.z < increment + 0.5)
            {
                creator = true;
                cam.GetComponent<camGyro>().speed += 1;
                Debug.Log(cam.GetComponent<camGyro>().speed);
                
            }
            if (player.transform.position.z > 500)
            {
                increment = i * 25;
            }

            if (creator == true)
            {
                if (i % 2 == 1)
                {
                    copy = Instantiate(levelBlock, inFront, levelRot.rotation);
                    Destroy(copy, 30f);
                    creator = false;
                    Debug.Log("i = " + i);
                    Debug.Log("level 1" + i % 2);
                }
                if (i % 2 == 0)
                {
                    copy = Instantiate(levelBlock2, inFront, levelRot2.rotation);
                    Destroy(copy, 30f);
                    creator = false;
                    Debug.Log("i = " + i);
                    Debug.Log("level 2" + i % 2);
                }

            }
        }
        
    }
}
