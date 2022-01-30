using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public int point = 0;
    public Text pointsText;
    public Rigidbody rb;

    private void Start()
    {
        pointsText.text = point.ToString();
        point = 0;
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            if (point < rb.position.y)
            {
                point = (int)rb.position.y;
                pointsText.text = Mathf.Round(point).ToString();
            } 
        }
    }
}

