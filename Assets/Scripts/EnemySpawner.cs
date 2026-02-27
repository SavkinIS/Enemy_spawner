using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay = 2;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private float _elapsedTime = 0f;
    private bool _isTicking = true;
    private Coroutine _spawnEnemyCoroutine;

    private void OnEnable()
    {
        _spawnEnemyCoroutine = StartCoroutine(SpawnEnemyCoroutine());
    }

    private void OnDisable()
    {
        StopCoroutine(_spawnEnemyCoroutine);
    }

    private void InstantiateEnemy()
    {
        var spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

        Enemy enemy = Instantiate(spawnPoint.GetEnemyPrefabPrefab, transform);
        enemy.gameObject.SetActive(true);

        enemy.Init(spawnPoint.transform.position, spawnPoint.GetTarget);
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        yield return new WaitForSeconds(_spawnDelay);

        while (_isTicking)
        {
            InstantiateEnemy();
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}