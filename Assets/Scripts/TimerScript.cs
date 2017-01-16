using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    private Text Text;
    public bool alive = true;
    private float timer;
    private float startTime;

    void GameOver(int something)
    {
        gameObject.SetActive(false);
    }

    void Victory()
    {
        float score = 300 - (Time.time - startTime);
        print("Score = " + ((int)score));
        int HighScore = PlayerPrefs.GetInt("HighScore", 0);

        Text Score = GameObject.FindGameObjectWithTag("Score Display").GetComponent<Text>();

        if ((int)score > HighScore)
        {
            PlayerPrefs.SetInt("HighScore", (int)score);
        }
        else
        {
            Text HighScoreText = GameObject.FindGameObjectWithTag("NewHighScore").GetComponent<Text>();
            HighScoreText.text = "Highest Score: " + HighScore;
        }
        gameObject.SetActive(false);
    }


    // Use this for initialization
    void Start () {
        startTime = Time.time;
        Text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - startTime < 300)
        { 
        timer += Time.deltaTime;
        var minutes = Mathf.Floor(timer / 60).ToString("00");
        var seconds = (timer % 60).ToString("00");
        Text.text = minutes + ":" + seconds;
        }
    }


  
}
