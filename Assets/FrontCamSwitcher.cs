using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCamSwitcher : MonoBehaviour
{
    public GameObject camFront;
    public GameObject camBack;
    
    public GameObject camFront2;
    public GameObject camBack2;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("v"))
        {
            if (camFront.activeInHierarchy == true)
            {
                camFront.SetActive(false);
                camBack.SetActive(true);
                
            }
            else
            {
                camFront.SetActive(true);
                camBack.SetActive(false);
                
            }
        }
        
        
        if (Input.GetKey("m"))
        {
            if (camFront2.activeInHierarchy == true)
            {
                camFront2.SetActive(false);
                camBack2.SetActive(true);
                
            }
            else
            {
                camFront2.SetActive(true);
                camBack2.SetActive(false);
                
            }
        }
       
    }

 
}
