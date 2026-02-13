using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    public int health = 5;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float maxHeight = 10f;
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        CheckDeath();
        if (transform.position.y >= maxHeight)
        {
            Destroy(gameObject);
            //dmg doen aan de speler hier.
        }
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        
            //hier later nog SFX
        }
    }
}
