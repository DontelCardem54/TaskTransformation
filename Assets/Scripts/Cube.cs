using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed);
    }
}
