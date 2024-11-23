using UnityEngine;
using System;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd = 1;

    // Event to notify when score is added
    public event Action<int> OnScoreAdded;

    private void Start()
    {
        // If scoreField is not assigned, try to find it
        if (scoreField == null)
        {
            scoreField = FindObjectOfType<NumberField>();
            if (scoreField == null)
            {
                Debug.LogWarning("ScoreAdder: No NumberField component found in the scene. Please assign a score field.");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggeringTag) && scoreField != null)
        {
            scoreField.AddNumber(pointsToAdd);
            OnScoreAdded?.Invoke(pointsToAdd); // Trigger the event and pass the points added

            // Destroy both the enemy and the laser (or other triggering object)
            Destroy(other.gameObject); // Destroy the laser
            Destroy(gameObject);       // Destroy the enemy
        }
    }

    public ScoreAdder SetScoreField(NumberField newTextField)
    {
        this.scoreField = newTextField;
        return this;
    }

    public ScoreAdder SetPointsToAdd(int newPointsToAdd)
    {
        this.pointsToAdd = newPointsToAdd;
        return this;
    }
}
