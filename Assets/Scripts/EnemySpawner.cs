using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
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
        Enemy enemy = Instantiate(_enemyPrefab, transform);
        enemy.gameObject.SetActive(true);
        var position = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
        enemy.Init(position.GetDirection(), position.transform);
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        yield return new WaitForSeconds(_spawnDelay);

        while (_isTicking)
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime >= _spawnDelay)
            {
                _elapsedTime = 0;
                InstantiateEnemy();
            }

            yield return null;
        }
    }
}