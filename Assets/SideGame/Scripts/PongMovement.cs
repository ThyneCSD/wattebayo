using UnityEngine;

public class PongMovement : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, ball.transform.position.y);
    }
}
