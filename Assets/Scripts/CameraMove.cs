using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerPosition;

    private void FixedUpdate()
    {
        if (playerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        }

        //left-right
        transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
    }
}
