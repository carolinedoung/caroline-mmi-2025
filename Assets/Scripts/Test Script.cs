using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float m_Threshold;
    [SerializeField] private CharacterController m_Player;

    Vector3 m_Origin;
    CharacterController m_CharacterController;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        m_Origin = m_Player.transform.position;
    }

    private void Update()
    {
        if (m_Player.transform.position.y < 0)
        {   
            // Respawn 
            Respawn();
            //Debug.Log("Game Over");
        }
    }

    private void Respawn()
    {
        m_Player.enabled = false;
        m_Player.transform.position = m_Origin;
        m_Player.enabled = true; 
    }

}

