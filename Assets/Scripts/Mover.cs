using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    
    private Vector3 _moveDirection;
    private bool _canMove;

    private void Update()
    {
        if (_canMove)
            Move();
    }

    private void Move()
    {
        Vector3 moveDirection = _moveDirection * _moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection);
    }

    public void EnableMove(bool canMove)
    {
        _canMove = canMove;
    }

    public void SetDirection(Vector3 direction)
    {
        _moveDirection =  direction;
    }
}