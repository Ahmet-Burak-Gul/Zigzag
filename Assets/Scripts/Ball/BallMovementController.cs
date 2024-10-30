using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;
    [SerializeField] private float ballMoveSpeed;

    // Update is called once per frame
    void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDiraction() * ballMoveSpeed * Time.deltaTime;
    }
}
