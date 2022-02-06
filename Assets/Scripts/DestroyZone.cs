using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    public Transform playerPosition;


    /*private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name != "Platform") && (collision.gameObject.tag != "Platform"))
        {
            Destroy(collision.gameObject);
        }
    }*/

    private void FixedUpdate()
    {
        if (playerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPosition.position.y - 23f, transform.position.z);
        }
    }
}
