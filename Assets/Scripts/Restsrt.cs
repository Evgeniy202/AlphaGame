using UnityEngine;
using UnityEngine.SceneManagement;

public class Restsrt : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DestroyZone")
        {
            SceneManager.LoadScene(0);
        }
    }
}
