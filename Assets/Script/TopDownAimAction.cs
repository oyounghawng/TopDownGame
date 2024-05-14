using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimAction : MonoBehaviour
{
    private TopDownController topdownController;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        topdownController = GetComponent<TopDownController>();
    }

    private void Start()
    {
        topdownController.OnLookEvent += Aim;
    }
    public void Aim(Vector2 direction)
    {
        RotateAim(direction);
    }

    private void RotateAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        spriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
