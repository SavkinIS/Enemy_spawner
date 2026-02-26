using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    
    private Transform _target;
    private bool _canMove;
    private Vector3 _direction;

    protected virtual void Update()
    {
        if (_canMove)
            Move();
    }

    public void EnableMove(bool canMove)
    {
        _canMove = canMove;
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
    
    private void Move()
    {
        _direction = (_target.position - transform.position).normalized;
        Vector3 moveDirection = _direction * _moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection,  Space.World);
    }
}