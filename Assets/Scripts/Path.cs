using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private List<Transform> _pathPoints;

    private int _currentPathPoint = 0;

    private int PointCount => _pathPoints.Count;

    private void Awake()
    {
        foreach (Transform point in _pathPoints)
            point.gameObject.SetActive(false);
    }

    public Transform GetPoint()
    {
        return _pathPoints[_currentPathPoint];
    }

    public void ChangePoint()
    {
        _currentPathPoint = (++_currentPathPoint) % PointCount;
    }
}