using UnityEngine;

public class SpawnPoint : MonoBehaviour, IDirectionGenerator
{
    public Vector3 GetDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
    }
}