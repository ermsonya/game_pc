using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam; 
    public float speed = 6f;
    public float turnSmothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(hor, 0f, ver).normalized;
        if (direction.magnitude >= 0.1f)
        {
        float targetAngle =Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg+cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
            
        }
    }
}
