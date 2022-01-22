using UnityEngine;

public class PlatformsMove : MonoBehaviour
{
    public static bool collisions;
    public Vector2 direction;
    public Rigidbody body;

    private float speed;

    private void Start()
    {
        speed = Random.Range(1f, 20f);
        body = GetComponent<Rigidbody>();
        collisions = false;
    }

    private void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        body.AddForce(direction.normalized * speed);
    }

    private void OnLeft(Collider collision)
    {
        if (collision.gameObject.tag == "BorderLeft")
        {
            direction.x -= speed;
        }
        else if (collision.gameObject.tag == "BorderRight")
        {
            direction.x = speed;
        }
    }
}
