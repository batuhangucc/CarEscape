using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;


    public float scoreCount;
    public float hiScoreCount;


    public bool scoreIncreasing;
    public float pointPerSecond;
    public delegate void ScoreMileStone();
    public event ScoreMileStone OnIncrease;
    public bool counting;
    public static ScoreManager instance;


    [SerializeField] private List<CarControl> carControl;


    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += 0.5f;


        }
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }
        IncreaseSpeed(scoreCount);
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);


    }


    public void IncreaseSpeed(float currentScore)
    {

        if (currentScore % 5000 == 0 && scoreIncreasing == true)
        {
            OnIncrease?.Invoke();

        }
    }


}