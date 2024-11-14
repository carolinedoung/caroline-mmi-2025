using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class peutimporte : MonoBehaviour
{   

    // Serialize veut dire qu'on peut modifier sur Unity
    [SerializeField] private float m_Threshold;

    Vector3 m_Origin;
    CharacterController m_CharacterController;
    [SerializeField] private CharacterController m_Player;

    private void Awake()
    {
        m_Origin = m_Player.transform.position;
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (m_Player.transform.position.y < 0)
        {
            Respawn();
        }
    }

    private void OnRespawn(InputValue value)
    {
        Respawn();
    }

    private void Respawn()
    {
        m_Player.enabled = false;
        m_Player.transform.position = m_Origin;
        m_Player.enabled = true;
    }
}
