using UnityEngine;

public class BallTransformCheck : MonoBehaviour
{
    [SerializeField] private float endYValue;
    public bool isDeathArea = false;

    private void Update()
    {
        CheckBallTransform();
    }

    private void CheckBallTransform()
    {
        if (transform.position.y <= endYValue)
        {
            isDeathArea = true;
        }
    }
}
