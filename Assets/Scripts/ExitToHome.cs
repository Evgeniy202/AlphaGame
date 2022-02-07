using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToHome : MonoBehaviour
{
    public void OnButtonToHomeDown()
    {
        SceneManager.LoadScene(0);
    }
}
