using UnityEngine;

public interface IDirectionGenerator
{
    Vector3 GetDirection();
}

public class SpawnPoint : MonoBehaviour, IDirectionGenerator
{
    public Vector3 GetDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
    }
}