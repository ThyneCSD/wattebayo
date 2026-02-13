using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private float currentAngle = 0f;
    void Update()
    {
        gameObject.transform.Translate(Vector2.up * speed * Time.deltaTime);

        currentAngle = transform.eulerAngles.z;


        //vraag me niet wat dit is pls
        if (currentAngle > 180f)
        {
            currentAngle -= 360f;
        }
        if (currentAngle < -180f)
        {
            currentAngle += 360f;
        }

        if (currentAngle < 1 && currentAngle > -1)
        {
            currentAngle = +30;
            currentAngle = +30;
        }
        if (currentAngle > -180 && currentAngle < 180)
        {
            currentAngle = -30;
            currentAngle = -30;
        }
        if (currentAngle > 150f)
        {
            currentAngle = 150f;
        }
        else if (currentAngle < -150f)
        {
            currentAngle = -150f;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ping"))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-30, -150));
            //-30, -150.
            Debug.Log("Collided with Ping");
        }
        else if (collision.gameObject.CompareTag("Pong"))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(30, 150));
            Debug.Log("Collided with Pong");
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            //90 werdt 180??

            
            if (currentAngle >= 30 && currentAngle <= 150)
            {
                transform.rotation = Quaternion.Euler(0, 0, currentAngle - 10);
                Debug.Log("Collided with a wall");
            }
            else if (currentAngle >= -150 && currentAngle <= -30)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -currentAngle + 10);
                Debug.Log("Collided with a wall");
            }
        }
    }
}
