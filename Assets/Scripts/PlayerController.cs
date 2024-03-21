using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody theRB;
    public float moveSpeed, jumpForce;

    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0f) * moveSpeed * Time.deltaTime;

        theRB.velocity = new Vector3(moveInput.x * moveSpeed, theRB.velocity.y, moveInput.y * moveSpeed);


        transform.Translate(movement);

        RaycastHit hit;
        if (Physics.Raycast(groundPoint.position, Vector3.down, out hit, .3f, whatIsGround))
        {
            isGrounded = true;

        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            theRB.velocity += new Vector3(0f, jumpForce, 0f);
        }

        if (moveInput.x > 0)
        {
            Debug.Log("Moving Right");
            anim.SetBool("IsWalkingLeft", false);
            anim.SetBool("IsIdle", true);
        }
        else if (moveInput.x < 0)
        {
            Debug.Log("Moving Left");
            anim.SetBool("IsWalkingLeft", true);
        }

        if (moveInput.y > 0)
        {
            Debug.Log("Moving Up");
        }
        else if (moveInput.y < 0)
        {
            Debug.Log("Moving Down");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.Play("Idle");
        }
    }

    public void CheckMovement()
    {
        float currentY = transform.position.y;
        float lastY = currentY;

        if (currentY > lastY)
        {
            Debug.Log("going down");
        }
        else
        {
            Debug.Log("going up");
        }
    }
}
