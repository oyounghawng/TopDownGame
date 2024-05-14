using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TopDownController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<TopDownController>();
    }
}
