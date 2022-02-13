using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsController : MonoBehaviour
{
    //events
    public static event Action<Quaternion> shootArrow;

    //other script ref
    private PlayerInput playerInput;

    //declaring components
    private Animator anim;

    //declaring variables
    private String aim = "aiming", shoot = "shoot";

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
        playerInput = this.GetComponent<PlayerInput>();
    }

    private void Update()
    {
        AimShootAnimation();
    }

    private void AimShootAnimation()
    {
        anim.SetBool(aim, PlayerInput.aiming);
        anim.SetBool(shoot, (PlayerInput.aiming && PlayerInput.shooting));
    }

    //animation events
    public void Shoot()
    {
        shootArrow?.Invoke(this.transform.rotation);
    }
}
