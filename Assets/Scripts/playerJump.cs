using UnityEngine;

public class playerJump : MonoBehaviour
{
    public Rigidbody body;
    public Rigidbody platform;
    public float jumpForce;

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") && (platform.position.y <= body.position.y + 1f))
        {
            body.AddForce(Vector2.up * jumpForce);
        }
    }


}
