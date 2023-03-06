using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * -transform.right);
    }
}
