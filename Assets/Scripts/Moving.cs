using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    void Update()
    {
        transform.Translate(_movementDirection, Space.World);
    }
}
