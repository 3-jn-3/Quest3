using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public PlayerInput playerInput;
    public Rigidbody2D rb;

    public Transform sprite;
    public GameObject bulletPrefab;
    private InputAction dropAction;

    public float speed = 1.0f;
    public float boundary = 8f;
    private int direction = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropAction = playerInput.actions.FindAction("Drop");
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer.hasEnded) return;

        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        if (transform.position.x>=boundary)
        {
            direction = -1;
        }

        else if (transform.position.x<=-boundary)
        {
            direction = 1;
        }

        if (dropAction.WasPressedThisFrame())
        {
            Drop();
        }
    }

    void Drop()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

}
