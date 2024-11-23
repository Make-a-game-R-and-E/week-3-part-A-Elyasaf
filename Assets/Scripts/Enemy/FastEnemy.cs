using UnityEngine;

public class FastEnemy : Enemy
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
