using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPRotated : MonoBehaviour
{
    public float speed = 30;
    public float Amplitude = 2.0f;
    public float TimeToRotate = 0.5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        Vector3 Pos = startPos;
        Pos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * TimeToRotate) * Amplitude;
        transform.position = Pos;
    }
}
