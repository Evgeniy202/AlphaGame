using UnityEngine;
using System.Threading;


public class PlayerMove : MonoBehaviour
{
    public static PlayerMove instance;

    public Vector2 direction;
    public float force;
    public float JumpForce;
    public Rigidbody rb;

    private bool isPlatform;

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
        //JumpLogic();
        MovementLogic();
    }

    private void MovementLogic()
    {
        rb.AddForce(direction.normalized * force);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if ((collision.gameObject.tag == "Platform") || (collision.gameObject.tag == "StandartPlatform"))
        {
            isPlatform = value;
        }
    }

    private void JumpLogic()
    {
        if (isPlatform)
        {
            rb.AddForce(Vector2.up * JumpForce);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
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
