using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizantalMove = 1f;
    
    void Update()
    {
        horizantalMove = Input.GetAxisRaw("Horizantal")*runSpeed;
    }
    private void FixedUpdate()
    {
        controller.Move(horizantalMove * Time.fixedDeltaTime , false ,false);
    }
}
