using TMPro;
using UnityEngine;
using System;

[RequireComponent(typeof(TextMeshProUGUI))]
public class NumberField : MonoBehaviour
{
    private int number;
    private TextMeshProUGUI textField;

    // Event to notify when the score is updated
    public event Action<int> OnScoreUpdated;

    private void Awake()
    {
        textField = GetComponent<TextMeshProUGUI>();
    }

    public int GetNumber()
    {
        return this.number;
    }

    public void SetNumber(int newNumber)
    {
        this.number = newNumber;
        UpdateText();

        // Invoke the event
        OnScoreUpdated?.Invoke(this.number);
    }

    public void AddNumber(int toAdd)
    {
        SetNumber(this.number + toAdd);
    }

    private void UpdateText()
    {
        if (textField != null)
        {
            textField.text = $"Score: {number}";
        }
    }
}
