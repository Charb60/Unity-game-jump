//using UnityEngine;
//using System.Collections;

//public class moveAtoB : MonoBehaviour
//{
// public Vector3 positionA;
//public Vector3 positionB;

//void Start()
//{
//  transform.position = positionA;
//}

// Update is called once per frame
//void Update()
//{
//    transform.position = Vector3.Lerp(transform.position, positionA, 0.005f);

//  }
//}
//public float degreesPerSecond = 2.0f;
//void Update()
//{
//transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveAtoB : MonoBehaviour
{
    public float speed = 1f;
    public float mm = 0f;
    public float limit = 2f;
    private bool iw = true;

    public bool movingRight = true;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        mm += Time.deltaTime;

        if (mm < limit)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(new Vector3(0, -180, 0), Space.Self);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            mm = 0;
        }
    }

}