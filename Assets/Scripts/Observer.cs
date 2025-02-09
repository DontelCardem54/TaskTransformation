using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform _follower;

    private void Update()
    {
        transform.LookAt(_follower);
    }
}
