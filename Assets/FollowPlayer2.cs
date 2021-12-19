using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    private Vector3 offset2 = new Vector3(6, 5, -5);


    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        
        transform.position = player2.transform.position +offset2;
            
      

    }
}
