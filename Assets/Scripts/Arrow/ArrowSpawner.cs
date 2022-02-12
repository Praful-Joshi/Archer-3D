using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    //declaring components
    public GameObject arrowPrefab;
    public Transform arrowSpawnPosition;
    private GameObject arrowInstance;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController.shootArrow += onShootArrow;
    }

    private void onShootArrow()
    {
        shootArrow();
    }

    private void shootArrow()
    {
        arrowInstance = Instantiate(arrowPrefab, arrowSpawnPosition.position, Quaternion.identity);
        arrowInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 25f, ForceMode.Impulse);
    }
}
