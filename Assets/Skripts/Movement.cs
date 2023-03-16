using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Variables
    public float speed = 5;
    public float boostSpeed;
    public float originalSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, zDirection, 0f);

        transform.position += moveDirection * speed;
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        */



        //On button push object gets boost and after release goes back to normal



        if (Input.GetButton("Jump"))
        {
            speed = boostSpeed;
            
        }

        else
        {
            speed = originalSpeed;

        }

        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
