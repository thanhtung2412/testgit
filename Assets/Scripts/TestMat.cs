using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMat : MonoBehaviour
{
    public Material[] mat;
    public Renderer renderer;
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            renderer.material = mat[0];
        }
        if (Input.GetKey(KeyCode.B))
        {
            renderer.material = mat[1];
        }

    }
}
