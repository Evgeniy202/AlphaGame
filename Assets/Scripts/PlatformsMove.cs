using UnityEngine;

public class PlatformsMove : MonoBehaviour
{
    private Vector3 targetPoint;
    private float speed;
    private float posX;

    private void Start()
    {
        int var = Random.Range(1, 2);
        if (var == 1)
        {
            posX = 19.5f;
        }
        else if (var == 2)
        {
            posX = -19.5f;
        }

        targetPoint = new Vector3(posX, transform.position.y, 15f);
        speed = Random.Range(0.04f, 0.1f); 
    }

    private void FixedUpdate()
    {
        Direction();
        MoveObj();
        targetPoint = new Vector3(posX, transform.position.y, 15f);
    }

    private void Direction()
    {
        if (transform.position.x >= 19)
        {
            posX = -19.5f;
        }
        else if (transform.position.x <= -19)
        {
            posX = 19.5f;
        }
    }

    private void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed);
    }
}
