using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public Text text1;
    public Text text2;

    private void Start()
    {
        text1.text = "Score: " + score.ToString();
        text2.text = "Score: " + score.ToString();
    }

    public void IncrementScore()
    {
        score++;
        text1.text = "Score: " + score.ToString();
        text2.text = "Score: " + score.ToString();
    }
}
