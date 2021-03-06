﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{

    [Header("Movement parameters: ")]
    [Tooltip("The amount of speed player can get when swimming.")]
    public float maxSwimSpeed;
    [Tooltip("The speed that the player use to acellerate.")]
    public float acellerationSpeed;
    [Tooltip("The rotate sensitivity.")]
    public float rotateSensitivity;

    private float swimSpeed;
    private float rSpeed = 120f;
    private float pMinLimit = -80f;
    private float pMaxLimit = 80f;
    private float pitchRot = 0.0f;
    private float yawRot = 0.0f;
    private enum State { playerControl, gameControl, }
    private State state;

    private CharacterController cc;
    private Animator anim;
    bool isMoving;

    private void LoadReferencesAndSetParameters()
    {
        state = State.playerControl;
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        LoadReferencesAndSetParameters();
    }

    private void SetMovementAnimationVelocity()
    {
        float blendVelocity = maxSwimSpeed / swimSpeed;             // This was firstly inverted => swimSpeed / maxSwimSpeed;
        anim.SetFloat("zSpeed", blendVelocity);
    }

    private void ConstrainPlayerMovement()
    {

    }

    private void PlayerMovementInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (swimSpeed < maxSwimSpeed)
            {
                swimSpeed += (acellerationSpeed * Time.deltaTime);
                swimSpeed *= 1.02f;
            }
            else
            {
                if (swimSpeed > 0.5f)
                {
                    swimSpeed *= 0.98f;
                }
                else
                {
                    swimSpeed = 0;
                }
            }
        }
        cc.Move(transform.position + transform.forward * swimSpeed * Time.deltaTime);
    }

    private void Update()
    {
        PlayerMovementInput();
    }
}
