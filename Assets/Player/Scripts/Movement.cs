using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float x, z;
    public CharacterController ctr;
    float MoveSpeed;
    public float Walk = 8f;
    public float Sprint = 14f;
    float Run = 0;
    Vector3 velocity;
    public float gravity= -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      move();
    }
    private void FixedUpdate()
    {
       
    }
    public void move()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {

            MoveSpeed = Sprint;
        }
        else
        {

            MoveSpeed = Walk;
        }
        Vector3 move = transform.right * x + transform.forward * z;
        ctr.Move(move * MoveSpeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        ctr.Move(velocity * Time.deltaTime);
    }

}
