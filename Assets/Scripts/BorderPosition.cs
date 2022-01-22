using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderPosition : MonoBehaviour
{
    public Transform playerPosition;

    private void FixedUpdate()
    {
        if (playerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        }
    }
}
