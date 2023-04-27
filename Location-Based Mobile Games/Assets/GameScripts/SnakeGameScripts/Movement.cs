using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movSpeed = 5;
    public float TrunAngle = 180;

    public static Movement instance;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        transform.position += transform.forward * movSpeed * Time.deltaTime;

        float TurnDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * TurnDirection * TrunAngle * Time.deltaTime);
    }
}
