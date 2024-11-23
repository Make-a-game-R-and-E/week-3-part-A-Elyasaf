using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Function to exit the game
    public void QuitGame()
    {
#if UNITY_EDITOR
        // Exit Play Mode in the Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Close the application
        Application.Quit();
#endif
    }
}