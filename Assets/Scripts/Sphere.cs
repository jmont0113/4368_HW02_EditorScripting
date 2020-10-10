using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] public float baseSize = 1.0f;

    void Update()
    {
        float animation = baseSize + Mathf.Sin(Time.time * 8.0f) * baseSize / 7.0f;
        transform.localScale = Vector3.one * animation;
    }
}
