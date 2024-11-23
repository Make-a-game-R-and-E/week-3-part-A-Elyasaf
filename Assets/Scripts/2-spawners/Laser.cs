using UnityEngine;
using System;

public class Laser : MonoBehaviour
{
    public event Action OnHitTarget;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Laser hit enemy");
            OnHitTarget?.Invoke();
            other.GetComponent<Enemy>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
