using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    //declaring variables
    [HideInInspector] public static bool aiming = false, shooting = false;

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    private void getInput()
    {
        aiming = Input.GetKey(KeyCode.Mouse1);
        shooting = Input.GetKey(KeyCode.Mouse0);
    }
}
