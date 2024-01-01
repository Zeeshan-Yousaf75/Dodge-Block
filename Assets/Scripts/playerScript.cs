using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed = 20;
    private float horizontalInput;

    private float xRange = 9.0f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x >= xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (horizontalInput > 0)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (horizontalInput < 0)
        {
           
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            
        }

    }


   
}

