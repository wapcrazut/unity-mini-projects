using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float forwardForce;
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float moveIncrement;

    bool isBallRolled = false;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Roll()
    {
        if (!isBallRolled) 
        {
            rb.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
            isBallRolled = true;
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > leftLimit)
        {
            transform.position += new Vector3(-moveIncrement, 0, 0);
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < rightLimit)
        {
            transform.position += new Vector3(moveIncrement, 0, 0);
        }
    }
}
