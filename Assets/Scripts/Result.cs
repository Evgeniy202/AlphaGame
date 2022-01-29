using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public float point = 0;
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
            point = rb.position.y;
            pointsText.text = Mathf.Round(point).ToString();    
        }
    }
}

