using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportPoint;

    private void TeleportPlayer(Transform playerTransform)
    {
        playerTransform.position = teleportPoint.position;
    }


    //transform.position = teleportPoint.position
    private void OnTriggerEnter(Collider other)
    {
        TeleportPlayer(other.transform);
    } 
}
