using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform obj; 

    void Update()
    {
        if (obj.position.y > transform.position.y) 
        {
            
            transform.position = new Vector3(transform.position.x, obj.position.y, transform.position.z);
        }
        if (obj.position.z > transform.position.z)
        {

            transform.position = new Vector3(transform.position.x, obj.position.y, transform.position.z);
        }
    }

}
