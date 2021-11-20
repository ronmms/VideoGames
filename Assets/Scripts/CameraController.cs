using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform camera;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camera.position.x, camera.position.y, transform.position.z);
    }
}
