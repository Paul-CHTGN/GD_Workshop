using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;

public class Teleport: MonoBehaviour
{
    private bool isInRange = false;
    public Transform TeleportePosition;
    public Movement player;
    public bool isVictoryDoor = false;
    public GameObject PanelVictory;


    void Start()
    {
        Debug.Log("je suis sur "+gameObject.name);  
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)) {
            player.enabled = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player.enabled = false;
        if (isVictoryDoor)
        {
            PanelVictory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        player.transform.position = TeleportePosition.position;

        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }



}
