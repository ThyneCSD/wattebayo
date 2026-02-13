using UnityEngine;

public class PingMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float maxAndMinY = 3.5f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < maxAndMinY)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.S) && transform.position.y > -maxAndMinY)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
