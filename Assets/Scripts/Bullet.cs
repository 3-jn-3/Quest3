using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gone()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Points points = Object.FindFirstObjectByType<Points>();

        if (other.GetComponent<Bad>() != null)
        {
            points.SubtractPoints(1);
            Destroy(gameObject);
        }
        else if (other.GetComponent<Good>() != null)
        {
            points.AddPoints(1);

        }
    }

}
