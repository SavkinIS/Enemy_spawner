using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    
    public void Init( Transform position, Transform target)
    {
        SetPosition(position);
        UpdateMove(target);
        transform.LookAt(target);
    }

    private void SetPosition(Transform position)
    {
        var oldParent = transform.parent;
        transform.parent = position;
        transform.localPosition = new Vector3(0,(transform.lossyScale.y), 0);
        transform.parent = oldParent;
    }

    private void UpdateMove(Transform target)
    {
        _mover.SetTarget(target);
        _mover.EnableMove(true);
    }
}