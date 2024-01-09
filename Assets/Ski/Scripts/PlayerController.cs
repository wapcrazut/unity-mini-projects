using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveForce;
    Rigidbody rb;
    float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.right * xInput * moveForce);
    }
}
