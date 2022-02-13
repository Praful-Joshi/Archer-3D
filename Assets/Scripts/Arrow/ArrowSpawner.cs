using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    //declaring components
    public Transform shoulderObject;
    public GameObject arrowPrefab;
    public Transform arrowSpawnPosition;
    private GameObject arrowInstance;

    //declaring variables
    public static RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimationsController.shootArrow += onShootArrow;
    }

    private void onShootArrow(Quaternion playerRotation)
    {
        shootArrow(playerRotation);
    }

    private void shootArrow(Quaternion playerRotation)
    {
        arrowInstance = Instantiate(arrowPrefab, arrowSpawnPosition.position, shoulderObject.rotation);
        if(Physics.Raycast(arrowSpawnPosition.position, shoulderObject.forward, out hit))
        {
            Debug.Log(hit.point);
        }

        arrowInstance.GetComponent<Rigidbody>().AddForce(shoulderObject.forward * 25f, ForceMode.Impulse);
    }
}
