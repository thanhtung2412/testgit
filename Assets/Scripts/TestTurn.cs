using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTurn : MonoBehaviour
{
    public float speed = 200f;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}