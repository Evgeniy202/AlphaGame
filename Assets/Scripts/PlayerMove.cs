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
        if ((rb.position.x < 22f) && (rb.position.x > -22f))
        {
            rb.AddForce(direction.normalized * force);
        }
        else if ((rb.position.x >= -22f))
        {
            rb.position = new Vector3(20f, rb.position.y, 15f);
        }
        else if ((rb.position.x <= 22f))
        {
            rb.position = new Vector3(-20f, rb.position.y, 15f);
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
