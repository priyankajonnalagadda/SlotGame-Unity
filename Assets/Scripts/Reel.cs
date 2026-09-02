
using UnityEngine;
using TMPro;

public class Reel : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private int currentIndex;
    private string[] symbols = { "🍒", "🍋", "🔔" };

    public void StartSpin()
    {
        currentIndex = Random.Range(0, symbols.Length);
        displayText.text = symbols[currentIndex];
    }

    public int GetResult()
    {
        return currentIndex;
    }
}
