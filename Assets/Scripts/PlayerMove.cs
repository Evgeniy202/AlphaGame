using UnityEngine;
using System.Threading;


public class PlayerMove : MonoBehaviour
{
    public static PlayerMove instance;

    public Vector2 direction;
    public float force;
    public float JumpForce;
    private Rigidbody rb;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        rb.AddForce(direction.normalized * force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Border")
        {
            rb.AddForce(Vector2.up * JumpForce);
        }   
    }

    public void OnLeftBtnDown()
    {
        direction.x -= force;  
    }

    public void OnRightBtnDown()
    {
        direction.x = force;
    }

    public void OnButtonUp()
    {
        direction.x = 0f;
    }

}
