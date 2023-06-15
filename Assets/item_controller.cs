using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            c = GetComponent<Collider2D>();
        }
        c.isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //saveScore
        Text txt;
        txt = GameObject.Find("/Canvas/Text").GetComponent<Text>();
        Gamemanager.nScore++;
        txt.text = "" + Gamemanager.nScore;


        //Add sound
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Destroy(gameObject, 0.5f);
    }
    void Update()
    {

    }
}
