using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;

    public Vector3 GetBallDiraction()
    {
        return ballInputController.ballDirection;
    }
}
