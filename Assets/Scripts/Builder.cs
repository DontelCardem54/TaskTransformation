using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField] private float _checkDistance;
    [SerializeField] private Transform _raycastPoint;
    [SerializeField] private Block _blockPrefab;
    [SerializeField] private BuildPrewive _buildPrewive;

    private RaycastHit _hitinfo;

    private Vector3 BuildPosition => _hitinfo.transform.position + _hitinfo.normal;

    private void Update()
    {
        if(_hitinfo.transform == null)
            return;

        if(_hitinfo.transform.GetComponent<Block>() == null) 
            return; 

        if (Input.GetMouseButtonDown(0)) 
            Build();
    }

    private void FixedUpdate()
    {
        if(Physics.Raycast(_raycastPoint.position, _raycastPoint.forward, out _hitinfo, _checkDistance))
        {
            if(_buildPrewive.IsActive == false)
            {
                _buildPrewive.Enable();
            }

            _buildPrewive.SetPosition(BuildPosition);
        }
        else
        {
            if (_buildPrewive.IsActive)
                _buildPrewive.Disable();
        }
    }

    private void Build()
    {
        Vector3 position = BuildPosition;

        Instantiate(_blockPrefab, position, Quaternion.identity);
    }
}
