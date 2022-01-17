using UnityEngine;

public class PlayerJamp : MonoBehaviour
{
    public float jumpForse;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerMove.instance.rb.AddForce(Vector2.up * jumpForse);
    }
}
