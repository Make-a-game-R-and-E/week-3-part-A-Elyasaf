using UnityEngine;

/**
 * This component instantiates random enemy prefabs at random time intervals and random bias from its object position.
 */
public class TimedSpawnerRandom : MonoBehaviour
{
    [SerializeField] Enemy[] enemyPrefabs; // Changed from a single prefab to an array of Enemy prefabs
    [Tooltip("Minimum time between consecutive spawns, in seconds")]
    [SerializeField] float minTimeBetweenSpawns = 0.2f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")]
    [SerializeField] float maxTimeBetweenSpawns = 1.0f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")]
    [SerializeField] float maxXDistance = 1.5f;
    [SerializeField] Transform parentOfAllInstances;

    void Start()
    {
        if (enemyPrefabs == null || enemyPrefabs.Length == 0)
        {
            Debug.LogError("TimedSpawnerRandom: No enemy prefabs assigned.");
            return;
        }
        SpawnRoutine();
    }

    async void SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            await Awaitable.WaitForSecondsAsync(timeBetweenSpawnsInSeconds); // Co-routines
            if (!this) break; // Might be destroyed when moving to a new scene

            // Randomly select an enemy prefab from the array
            int randomIndex = Random.Range(0, enemyPrefabs.Length);
            Enemy prefabToSpawn = enemyPrefabs[randomIndex];

            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, maxXDistance),
                transform.position.y,
                transform.position.z
            );

            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.transform.parent = parentOfAllInstances;
        }
    }
}
