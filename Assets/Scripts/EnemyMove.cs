using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 5.0f;

    private bool moveRight = false;
    private bool moveForward = false;
    
    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (moveForward)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        else
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (moveRight && transform.position.x > 7)
        {
            moveRight = false;
        }
        else if (!moveRight && transform.position.x < -7)
        {
            moveRight = true;
        }

        if (moveForward && transform.position.z > 4)
        {
            moveForward = false;
        }
        else if (!moveForward && transform.position.z < -4.8)
        {
            moveForward = true;
        }

    }

}
