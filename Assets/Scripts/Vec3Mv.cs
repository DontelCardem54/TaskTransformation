using UnityEngine;

public class Vec3Mv : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _player.position, _speed * Time.deltaTime);
    }
}
