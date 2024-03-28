using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TPC : MonoBehaviour
{

    // public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;

    private float jum = 5f;
    private float Dis = 5f;
    public GameObject Groundcheck;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Grounded();
        Jump();
        Move();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        }
    }

    private void Grounded()
    {
        if (Physics.CheckSphere(Groundcheck.transform.position, Dis, layerMask))
        {
            this.grounded = true;
        }
        else
        {
            this.grounded = false;
        }

       // this.anim.SetBool("jump", !this.grounded);
    }

    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
        movement.Normalize();

        this.transform.position += movement * speed;

       // this.anim.SetFloat("vertical", verticalAxis);
      //  this.anim.SetFloat("horizontal", horizontalAxis);
    }
}