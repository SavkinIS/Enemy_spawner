using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;

    
    public void Init(Vector3 direction, Transform position)
    {
        SetPosition(position);
        UpdateMove(direction);
        transform.LookAt(transform.position + direction);
    }

    private void SetPosition(Transform position)
    {
        var oldParent = transform.parent;
        transform.parent = position;
        transform.localPosition = new Vector3(0,(transform.lossyScale.y), 0);
        transform.parent = oldParent;
    }

    private void UpdateMove(Vector3 direction)
    {
        _mover.SetDirection(direction);
        _mover.EnableMove(true);
    }
}