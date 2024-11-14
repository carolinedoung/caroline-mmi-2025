using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TriggerCollectible : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }
        Debug.Log("Entre dans la zone du collectible");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }
        Debug.Log("Se ballade dans la zone du collectible");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }
        Debug.Log("Quitte la zone du collectible");
    }
}

