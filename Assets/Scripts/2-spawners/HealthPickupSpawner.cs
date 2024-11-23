using UnityEngine;

/**
 * This component spawns health pickups at random intervals and positions above the screen.
 */
public class HealthPickupSpawner : MonoBehaviour
{
    [SerializeField] GameObject healthPickupPrefab;
    [SerializeField] float minTimeBetweenSpawns = 10f;
    [SerializeField] float maxTimeBetweenSpawns = 20f;
    [SerializeField] float spawnXRange = 10f; // Adjust based on your game's width

    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private System.Collections.IEnumerator SpawnRoutine()
    {
        while (isSpawning)
        {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);

            // Random X position within the specified range
            float randomX = Random.Range(-spawnXRange, spawnXRange);

            Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);

            // Instantiate the health pickup
            Instantiate(healthPickupPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void StopSpawning()
    {
        isSpawning = false;
    }
}
