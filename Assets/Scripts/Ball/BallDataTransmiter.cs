using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;
    [SerializeField] private BallTransformCheck ballTransformCheck;

    public Vector3 GetBallDiraction()
    {
        return ballInputController.ballDirection;
    }

    public bool GetCheckBallISDeathArea()
    {
        return ballTransformCheck.isDeathArea;
    }
}
