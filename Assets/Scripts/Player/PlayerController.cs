using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    private String aim = "aiming", shoot = "shoot";
    private bool aiming = false, shooting = false;

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
    }

    private void Update()
    {
        getInput();
        AimShootAnimation();
    }

    private void AimShootAnimation()
    {
        anim.SetBool(aim, aiming);
        anim.SetBool(shoot, (aiming && shooting));
    }

    private void getInput()
    {
        aiming = Input.GetKey(KeyCode.Mouse1);
        shooting = Input.GetKey(KeyCode.Mouse0);
    }

    public void Shoot()
    {
        Debug.Log("Arrow shot");
    }
}
