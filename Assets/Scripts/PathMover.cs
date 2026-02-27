using UnityEngine;

public class PathMover : Mover
{
    [SerializeField] private Path _path;

    private float _arrivalThreshold = 0.1f;

    private void Awake()
    {
        SetTarget(_path.GetPoint());
    }

    protected override void Update()
    {
        base.Update();

        var distance = (_path.GetPoint().position - transform.position).sqrMagnitude;

        if (distance < _arrivalThreshold)
        {
            _path.ChangePoint();
            SetTarget(_path.GetPoint());
        }
    }
}