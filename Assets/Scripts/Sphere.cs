using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward, Space.Self);
    }
}
