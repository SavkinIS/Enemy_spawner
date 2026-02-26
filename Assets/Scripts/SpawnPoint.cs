using UnityEngine;
using UnityEngine.Serialization;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _target;

    public Enemy GetEnemyPrefabPrefab => _enemyPrefab;
    
    public Transform GetTarget => _target;
    
}