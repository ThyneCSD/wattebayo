using UnityEngine;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI tmpluh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpluh.text = points.ToString();
        
    }
}
