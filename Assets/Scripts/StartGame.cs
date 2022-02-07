using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
