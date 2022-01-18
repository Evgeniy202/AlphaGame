using UnityEngine;

public class PlatformSpawnPosition : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "BorderBottom")
        {
            float newPosX = Random.Range(-10f, 10f);
            float newPosY = Random.Range(transform.position.y + 20f, transform.position.y + 25f);

            transform.position = new Vector3(newPosX, newPosY, 15f);
        }
    }
}
