using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        
    private float horizontal;
    private float vertical;
    private float speed = 10f;
    
    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y - 1f, vertical * speed * 2);
    }
}
