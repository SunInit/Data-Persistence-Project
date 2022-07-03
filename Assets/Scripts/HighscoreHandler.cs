using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreHandler : MonoBehaviour
{
    public static HighscoreHandler Instance;

    public static string playerName;
    public static int bestScore;
    public static string bestPlayer;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighscore();
    }

    private void LoadHighscore()
    {
        if (PlayerPrefs.HasKey("name") && PlayerPrefs.HasKey("bestScore"))
        {
            bestPlayer = PlayerPrefs.GetString("name");
            bestScore = PlayerPrefs.GetInt("bestScore");
        }
        else
        {
            bestPlayer = playerName;
            bestScore = 0;
        }
    }

    public void SaveHighscore()
    {
        PlayerPrefs.SetString("name", bestPlayer);
        PlayerPrefs.SetInt("bestScore", bestScore);
    }

    public void ResetHighscore()
    {
        PlayerPrefs.SetString("name", playerName);
        PlayerPrefs.SetInt("bestScore", 0);
        LoadHighscore();
    }
}
