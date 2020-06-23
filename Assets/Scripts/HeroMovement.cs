using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] public float walkSpeed;

    [SerializeField] public Rigidbody2D rigidbody;

    [SerializeField]
    public Animator animator;

    private Vector2 movement;
 
    // Update is called once per frame
    void Update()
    {
        // input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("side", -1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("side", 0);
        }

        if (movement.Equals(Vector2.zero))
        {
            animator.SetFloat("speed", 0f);
        }
        else
        {
            animator.SetFloat("speed", 1.0f);
        }
    }

    // movement
    private void FixedUpdate()
    {
        
        rigidbody.MovePosition(rigidbody.position + movement * walkSpeed * Time.fixedDeltaTime);


        // TODO verify the direction of the movement
        // TODO trigger animation when walking
        
    }
}
