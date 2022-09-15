using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, world");     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,14,0);
        }
        else if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(6,0,0);
        }
        else if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-6, 0, 0);
        }
    }
   
}