using System.Collections;
using UnityEngine;

public class BeatColourChanger : MonoBehaviour
{
    public Color beatColor;

    private SpriteRenderer sr;
    private Color originalColor;
    float[] timeDifference = { .5f, .5f, 1f, 1f, 1f, 1.5f };

    public bool grabbedCurrently = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;

        gameObject.layer = LayerMask.NameToLayer("Default");

        StartCoroutine(ChangeColorOnBeat());
    }

    IEnumerator ChangeColorOnBeat()
    {
        while (true)
        {
            sr.color = beatColor;
            gameObject.layer = LayerMask.NameToLayer("Wall");
            yield return new WaitForSeconds(.5f);
            while (grabbedCurrently)
            {
                yield return null;
            }
            sr.color = originalColor;
            gameObject.layer = LayerMask.NameToLayer("Default");

            yield return new WaitForSeconds(timeDifference[Random.Range(0, timeDifference.Length)] - .5f);
        }
    }
}
