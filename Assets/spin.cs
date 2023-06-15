using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
       public float degreesPerSecond = 2.0f;
    void Update()
    {
    transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
    }
}
