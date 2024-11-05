using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] GroundDataTransmitter groundDataTransmitter;

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValue();
        }
    }
}
