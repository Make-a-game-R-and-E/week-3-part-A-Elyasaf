using UnityEngine;

/**
 * A basic enemy that moves straight down.
 */
public class BasicEnemy : Enemy
{
    [Header("Movement Settings")]
    [SerializeField] private Vector3 velocity;

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        // Move the enemy
        transform.position += velocity * Time.deltaTime;
    }
}
