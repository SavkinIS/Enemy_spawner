using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    
    public void Init( Vector3 position, Transform target)
    {
        SetPosition(position);
        UpdateMove(target);
        transform.LookAt(target);
    }

    private void SetPosition(Vector3 position)
    {
       transform.position = new Vector3(position.x ,(transform.lossyScale.y), position.z);
    }

    private void UpdateMove(Transform target)
    {
        _mover.SetTarget(target);
    }
}