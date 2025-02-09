using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = (_player.position - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime, Space.World);
    }
}