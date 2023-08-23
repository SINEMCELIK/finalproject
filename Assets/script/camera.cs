using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class camera : MonoBehaviour
{

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    public float mouseSensivity = 100f;
    public GameObject oyuncu;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;

        xRotation -= mouseY;
        yRotation -= mouseY;

        yRotation = Mathf.Clamp(yRotation, -10f, 20f);
        xRotation = Mathf.Clamp(xRotation, -10f, 30f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        oyuncu.transform.rotation *= Quaternion.Euler(0, mouseX, 0);

    }
}
