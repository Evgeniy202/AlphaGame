using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject platform;
    public GameObject player;
    private GameObject newPlatform;

    /*private void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 30; i++)
        {
            SpawnerPosition.x = Random.Range(-10f, 10f);
            SpawnerPosition.y = Random.Range(5f, 50f);
            SpawnerPosition.z = 15f;

            Instantiate(newPlatform, SpawnerPosition, Quaternion.identity);
        }
    }*/

    private void FixedUpdate()
    {
        if (playerPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPosition.position.y - 10f, transform.position.z);
        }

        //left-right
        transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider collision)
    {
        newPlatform = (GameObject)Instantiate
            (platform, new Vector3(
                Random.Range(-10f, 10f), 
                player.transform.position.y + (14 + Random.Range(0.5f, 1f)), 15f), 
            Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
