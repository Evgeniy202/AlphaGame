using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject btnExitToHome;

    public void OnButtonDown()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            btnExitToHome.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            btnExitToHome.SetActive(false);
        }
    }
}
