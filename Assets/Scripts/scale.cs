using UnityEngine;

public class scale : MonoBehaviour
{
    public float scalingFactor = 5.0f; // This value can be set in the Inspector

    void Update()
    {
        float newScale = Mathf.Lerp(1f, scalingFactor, Time.deltaTime / 10f);
        transform.localScale = new Vector3(newScale, newScale, 1f);
    }
}