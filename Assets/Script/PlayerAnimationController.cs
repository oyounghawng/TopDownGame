using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : TopDownAnimationController
{
    private static readonly int IsRunning = Animator.StringToHash("IsRun");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();

    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void Move(Vector2 obj)
    {
        animator.SetBool(IsRunning, obj.magnitude > magnituteThreshold);
    }
}
