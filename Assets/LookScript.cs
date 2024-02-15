using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    // Rotation
    private float xRotation;
    private float yRotation;

    // Inputs
    private float mouseX;
    private float mouseY;

    [SerializeField] Transform head;
    [SerializeField] Transform body;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");
    }
    void FixedUpdate()
    {

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        head.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        body.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
