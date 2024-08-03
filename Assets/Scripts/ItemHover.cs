using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHover : MonoBehaviour
{
    public float BounceHeight = 0.5f;
    public float BounceSpeed = 1f;
    public float RotationSpeedX = 45f;
    public float RotationSpeedY = 10f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * BounceSpeed) * BounceHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);

        transform.Rotate(Vector3.up, RotationSpeedX * Time.deltaTime, Space.World);

        transform.Rotate(Vector3.right, RotationSpeedY * Time.deltaTime, Space.World);
    }
}