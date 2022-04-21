using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public Transform cam; 
    public float speed = 6f;
    public float jumpForce=15;
    public float moveForce=10;
    public float gravity;
    public float mspeed = 0;
    public float jspeed = 0;
    public float turnSmothTime = 0.1f;
    float turnSmoothVelocity;
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float hor = 0;
        float ver = 0;
        if (controller.isGrounded)
        {
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jspeed = jumpForce;
                //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) { 
                    
                //mspeed = moveForce;}
                //else { 
                //    jspeed = jumpForce;}
            }
        }
        jspeed += gravity * Time.deltaTime * 3f;
        Vector3 dir = new Vector3(0, jspeed * Time.deltaTime, 0);
        controller.Move(dir);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed += 5;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
          speed -= 5;   
        }
       
            
        Vector3 direction = new Vector3(hor,0, ver).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
            

        }
    }
}
