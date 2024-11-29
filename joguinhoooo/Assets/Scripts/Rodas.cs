using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodas : MonoBehaviour
{
   public WheelJoint2D controle;
   public JointMotor2D motor;
   public float speed;

    // Start is called before the first frame update
    void Start()
    {
       controle = GetComponent<WheelJoint2D>();
       motor = controle.motor;
    }

    // Update is called once per frame
    void Update()
    {
       float force = Input.GetAxis("Horizontal");
       motor.motorSpeed = speed * force;
       controle.motor = motor;
    }
}

