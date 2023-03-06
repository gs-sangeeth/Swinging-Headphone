using UnityEngine;

public class RythmManager : MonoBehaviour
{
    public GameObject outline;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            outline.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            outline.SetActive(false);
        }
    }
}
