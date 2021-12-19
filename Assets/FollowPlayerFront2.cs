using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFront2 : MonoBehaviour
{
    private Vector3 frontset2 = new Vector3(6, 2, 3);
    
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player2.transform.position +frontset2;
    }
}
