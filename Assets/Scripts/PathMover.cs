using UnityEngine;

public class PathMover : Mover
{
    [SerializeField]  private Path _path;
    
    private float _arrivalThreshold = 0.1f;
    private int _currentPathPoint = 0;

    private void Awake()
    {
        EnableMove(true);
        SetTarget(_path.GetPoint(_currentPathPoint));
    }

    protected override void Update()
    {
        base.Update();

        if (Vector3.Distance(transform.position, _path.GetPoint(_currentPathPoint).position) < _arrivalThreshold)
        {
            _currentPathPoint++;
            
            if (_currentPathPoint >= _path.PointCount)
                _currentPathPoint = 0;
            
            SetTarget(_path.GetPoint(_currentPathPoint));
        }
    }
}