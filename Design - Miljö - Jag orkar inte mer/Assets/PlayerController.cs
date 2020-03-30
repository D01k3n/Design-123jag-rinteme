using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 10;
    float sensitivity = 100;
    Transform camera;

    void Start()
    {
        camera = Camera.main.transform;
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        camera.Rotate(-Vector3.right * mouseY * sensitivity * Time.deltaTime);
        transform.Rotate(transform.up * mouseX * sensitivity * Time.deltaTime);

    }
}
