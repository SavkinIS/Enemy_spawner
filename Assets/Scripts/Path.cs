using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField]  private List<Transform> _pathPoints;
    
    public int PointCount => _pathPoints.Count;

    private void Awake()
    {
        foreach (Transform point in _pathPoints)
            point.gameObject.SetActive(false);
    }
    
    public Transform GetPoint(int index)
    {
        return _pathPoints[index];
    }
}