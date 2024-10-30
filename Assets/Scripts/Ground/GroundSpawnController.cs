using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;

    public GameObject lastGroundObjet;
    private GameObject newGroundObjet;

    private int groundDirection;
    void Start()
    {
       GanerateRandomGround();
    }

    private void GanerateRandomGround()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround()
    {
        groundDirection = Random.Range(0,2);

        if (groundDirection == 0)
        {
            newGroundObjet = Instantiate(groundPrefab, new Vector3(lastGroundObjet.transform.position.x - 1f, lastGroundObjet.transform.position.y, lastGroundObjet.transform.position.z),Quaternion.identity);
            lastGroundObjet = newGroundObjet;
        }
        else
        {
            newGroundObjet = Instantiate(groundPrefab, new Vector3(lastGroundObjet.transform.position.x, lastGroundObjet.transform.position.y, lastGroundObjet.transform.position.z + 1f), Quaternion.identity);
            lastGroundObjet = newGroundObjet;
        }
    }
}
