using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    [SerializeField] private Rigidbody2D rb;
    Animator animator;
    // Update is called once per frame
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        animator.SetFloat("MovementX", horizontal);
        animator.SetFloat("MovementY", vertical);

        if (horizontal == 0 && vertical == 0)
        {
            animator.SetBool("Moving", false);
        }
        else
        {
            animator.SetBool("Moving", true);
        }
    }
}
