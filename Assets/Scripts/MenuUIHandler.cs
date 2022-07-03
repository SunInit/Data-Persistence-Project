using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public InputField nameInput;
    public TextMeshProUGUI helloText;
    public Button startButton;

    private void Update()
    {
        if (nameInput.text.Length > 1)
        {
            startButton.interactable = true;
        }
    }
    public void GettingName()
    {
        HighscoreHandler.playerName = nameInput.text;
        
        helloText.text = $"Hello, {nameInput.text}";
    }

    public void StartGame() => SceneManager.LoadScene(1);

    public void ResetScore() => HighscoreHandler.Instance.ResetHighscore();
}
