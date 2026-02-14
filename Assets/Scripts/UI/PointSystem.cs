using UnityEngine;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI tmpluh;

    void Update()
    {
        tmpluh.text = points.ToString();
    }
}
