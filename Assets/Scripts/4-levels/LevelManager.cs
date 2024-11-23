using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class LevelManager : MonoBehaviour
{
    [Tooltip("The score required to advance to the next level")]
    [SerializeField] int targetScore = 20;

    [Tooltip("The name or index of the next scene to load")]
    [SerializeField] string nextSceneName;

    private NumberField scoreField;

    private void Start()
    {
        // Find the NumberField component that tracks the score
        scoreField = FindObjectOfType<NumberField>();
        if (scoreField == null)
        {
            Debug.LogError("LevelManager: No NumberField component found in the scene.");
            return;
        }

        // Subscribe to the score updated event
        scoreField.OnScoreUpdated += CheckScore;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event to prevent memory leaks
        if (scoreField != null)
        {
            scoreField.OnScoreUpdated -= CheckScore;
        }
    }

    private void CheckScore(int currentScore)
    {
        if (currentScore >= targetScore)
        {
            // Load the next scene
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
