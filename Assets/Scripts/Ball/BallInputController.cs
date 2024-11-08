using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;
    void Start()
    {
        ballDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeballDirection();
        }
    }

    private void ChangeballDirection()
    {
        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
