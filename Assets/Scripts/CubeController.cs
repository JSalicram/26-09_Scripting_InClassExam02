using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody cubeRB;

    private void Start()
    {
        cubeRB = this.gameObject.GetComponent<Rigidbody>();
    }

    private void MoveCubeForward()
    {
        cubeRB.velocity = new Vector3(-10, cubeRB.velocity.y, cubeRB.velocity.z);
    }

    private void FixedUpdate()
    {
        MoveCubeForward();
    }
}
