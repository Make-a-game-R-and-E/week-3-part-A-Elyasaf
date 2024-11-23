using UnityEngine;

public class LoadSpecificScene : MonoBehaviour
{
    [SerializeField]
    private int sceneIndex;

    public void LoadScene()
    {
        // Load the scene with the specified index
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
}
