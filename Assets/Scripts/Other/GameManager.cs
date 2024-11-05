using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallDataTransmiter ballDataTransmiter;
    void Update()
    {
        IsGamaOver();
    }

    private void IsGamaOver()
    {

        if (ballDataTransmiter.GetCheckBallISDeathArea())
        {
            SceneManager.LoadScene(0);
        }
    }
}
