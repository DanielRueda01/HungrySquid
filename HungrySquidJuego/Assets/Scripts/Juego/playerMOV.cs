using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMOV : MonoBehaviour
{

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(8000 * Time.deltaTime * Vector3.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(8000 * Time.deltaTime * Vector3.down);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(8000 * Time.deltaTime * Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(8000 * Time.deltaTime * Vector3.right);
        }
    }



}
