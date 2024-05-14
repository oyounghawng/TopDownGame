using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LimitInputSystem : MonoBehaviour
{
    PlayerInput playerInput;
    private void Awake()
    {
        playerInput = GameManager.Instance.player.GetComponent<PlayerInput>();
    }
    private void OnEnable()
    {
        playerInput.DeactivateInput();
    }
    private void OnDisable()
    {
        if(playerInput != null)
        {
            playerInput.ActivateInput();
        }    
    }
}
