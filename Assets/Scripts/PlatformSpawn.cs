using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platform;

    private void Start()
    {
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < 20; i++)
        {
            spawnPos.x = Random.Range(-18f, 18f);
            spawnPos.y += Random.Range(2.5f, 5f);
            spawnPos.z = 15f;

            Instantiate(platform, spawnPos, Quaternion.identity);
        }
    }
}
