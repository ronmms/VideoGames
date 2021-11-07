using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 20)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > 12)
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 2)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        Debug.Log("test");
        

    }
}

