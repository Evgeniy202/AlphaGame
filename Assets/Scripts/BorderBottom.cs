using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderBottom : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "BorderBottom")
        {
            float RandX = Random.Range(-18f, 18f);
            float RandY = Random.Range(transform.position.y + 55f, transform.position.y + 70f);
            
            transform.position = new Vector3(RandX, RandY, 15f);
        }
    }
}
