using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController topdownController;

    private Rigidbody2D rigid;


    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        topdownController = GetComponent<TopDownController>();
    }

    private void Start()
    {
        topdownController.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        rigid.velocity = direction * 2f;
    }
}
