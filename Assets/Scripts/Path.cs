using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Path : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;

    private int _currentPathPoint = 0;

    private void Awake()
    {
        foreach (Transform point in _points)
            point.gameObject.SetActive(false);
    }

    public Transform GetPoint()
    {
        return _points[_currentPathPoint];
    }

    public void ChangePoint()
    {
        _currentPathPoint = (++_currentPathPoint) % _points.Count;
    }
}