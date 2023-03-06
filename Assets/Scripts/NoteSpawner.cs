using System.Collections;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject note;

    private void Start()
    {
        StartCoroutine(SpawnNote());
    }

    IEnumerator SpawnNote()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            Instantiate(note, transform.position, Quaternion.identity);
        }
    }
}
