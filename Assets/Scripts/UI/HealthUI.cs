using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Image[] hearts; // Array of heart images
    [SerializeField] Sprite fullHeart; // Sprite for full heart
    [SerializeField] Sprite emptyHeart; // Sprite for empty heart

    public void SetHealth(int health)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
