using UnityEngine;

public class MinecraftMovement : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    [SerializeField] private float _speed;

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis(Horizontal), 0f, Input.GetAxis(Vertical));
        transform.Translate(_speed * Time.deltaTime * direction);
    }
}
