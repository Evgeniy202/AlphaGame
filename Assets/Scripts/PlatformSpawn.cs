using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject newPlatform;

    private void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 30; i++)
        {
            SpawnerPosition.x = Random.Range(-10f, 10f);
            SpawnerPosition.y = Random.Range(1f, 50f);
            SpawnerPosition.z = 15f;

            Instantiate(newPlatform, SpawnerPosition, Quaternion.identity);
        }
    }
}
