using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private Transform _center;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _distance;

    private void Start()
    {
        _offset = transform.position - _center.position;
    }

    void Update()
    {

        _distance = _offset.magnitude;
        transform.position = _center.position + _offset;
        transform.RotateAround(_center.position, transform.up, _speed * Time.deltaTime);
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
        _offset = transform.position - _center.position;
    }
}
