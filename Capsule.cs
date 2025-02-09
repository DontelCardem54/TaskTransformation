using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _growSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed;
    }
}
