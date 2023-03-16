using System.Collections;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject note;

    float[] timeDifference = { .5f, .5f, 1f, 1f, 1f, 1.5f };

    private void Start()
    {
        StartCoroutine(SpawnNote());
    }

    IEnumerator SpawnNote()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeDifference[Random.Range(0, timeDifference.Length)]);
            Instantiate(note, transform.position, Quaternion.identity);
        }
    }
}
