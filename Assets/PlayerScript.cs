using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Unity Objects
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform body;


    // Control Axes
    private float horizontal;
    private float vertical;

    // Mods
    private float speedMod = 10;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        var forceVector = (body.forward * vertical + body.right * horizontal) * speedMod;
        rb.AddForce(forceVector);

    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
}
