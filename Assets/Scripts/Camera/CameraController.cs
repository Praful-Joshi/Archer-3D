using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //other script ref
    public PlayerInput playerInput;

    //declaring components
    public GameObject playerFollowCam;
    public GameObject playerAimCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerFollowCam.SetActive(!playerInput.aiming);
        playerAimCam.SetActive(playerInput.aiming);
    }
}
