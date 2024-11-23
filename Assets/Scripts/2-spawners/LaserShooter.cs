using UnityEngine;
using TMPro;
using System;
using UnityEngine.InputSystem;
/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the score when the laser hits its target.
 */
public class LaserShooter : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The laser prefab to spawn")]
    private GameObject laserPrefab;

    [SerializeField]
    [Tooltip("How to shoot lasers")]
    InputAction shoot = new InputAction(type: InputActionType.Button, binding: "<Keyboard>/space");

    void OnEnable()
    {
        shoot.Enable();
    }

    void OnDisable()
    {
        shoot.Disable();
    }

    private void Update()
    {
        // shoot when the player presses the space key
        if (shoot.triggered)
        {
            SpawnLaser();
        }
    }

    private void SpawnLaser()
    {
        GameObject newLaser = Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
    }
}
