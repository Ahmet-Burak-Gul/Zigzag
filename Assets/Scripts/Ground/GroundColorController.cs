using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material grounMaterial;

    [SerializeField] private Color[] colors;
    private int colorIndex;

    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;

    void Update()
    {
        ColorChangeTimer();
        SetSmoothGroundColorChange();
    }

    private void ColorChangeTimer()
    {
        if (currentTime <= 0)
        {
            ChangeColorIndex();
            currentTime = time;
        }else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void ChangeColorIndex()
    {
        colorIndex++;
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SetSmoothGroundColorChange()
    {
        grounMaterial.color = Color.Lerp(grounMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        grounMaterial.color = colors[0];
    }
}
