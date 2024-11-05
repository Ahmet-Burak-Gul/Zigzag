using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    [SerializeField] private GroundSpawnController spawnController;

    private Rigidbody rb;

    [SerializeField] private float endYValue;
    private int groundDirection;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if (endYValue >= transform.position.y)
        {
            SetRigidbodyValue();
            SetGroundNewPosition();
        }
    }

    private void SetGroundNewPosition()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(spawnController.lastGroundObjet.transform.position.x - 1f, spawnController.lastGroundObjet.transform.position.y, spawnController.lastGroundObjet.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(spawnController.lastGroundObjet.transform.position.x, spawnController.lastGroundObjet.transform.position.y, spawnController.lastGroundObjet.transform.position.z + 1f);
        }

        spawnController.lastGroundObjet = this.gameObject;
    }

    private void SetRigidbodyValue()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
