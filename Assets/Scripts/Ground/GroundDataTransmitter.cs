using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;

    public void SetGroundRigidbodyValue()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }
}
