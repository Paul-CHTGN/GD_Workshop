using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;

public class Teleport: MonoBehaviour
{
    private bool isInRange = false;
    public Transform TeleportePosition;
    public Movement player;


    void Start()
    {
        Debug.Log("je suis sur "+gameObject.name);  
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G)) {
            player.enabled = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player.enabled = false;
        player.transform.position = TeleportePosition.position;

        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }



}
