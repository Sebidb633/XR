using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int score;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private int highScore;
    [SerializeField]
    private TextMeshProUGUI highScoreText;

    private void Start()
    {
        ReadScore();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("scoreVal",score);
    }

    public void ReadScore()
    {
        highScore = PlayerPrefs.GetInt("scoreVal");
        highScoreText.text = highScore.ToString();
    }
}
