using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    void Update()
    {
        transform.localScale += Vector3.one * _growSpeed;
    }
}
