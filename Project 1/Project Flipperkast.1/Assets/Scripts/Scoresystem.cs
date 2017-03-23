using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoresystem : MonoBehaviour
{

    public int score;
    public Text scoretext;
    public int highscore;
    public Text highscoretext;
    public Text hiscogo; // HighScore Game Over
    public Text cuscogo; //Current Score Game Over

    // Update is called once per frame
    void Update()
    {

        score = GameObject.Find("BumperLeft").GetComponent<ScoreCount>().score
        + GameObject.Find("BumperRight").GetComponent<ScoreCount>().score
        + GameObject.Find("BumperTop").GetComponent<ScoreCount>().score
        + GameObject.Find("WallBumpL").GetComponent<ScoreCount>().score
        + GameObject.Find("WallBumpR").GetComponent<ScoreCount>().score;
        scoretext.text = score.ToString();
        //de score word opgetelt door al deze componenten (dus alle bumpers). Dit word aangegeven via de inspector.
        if (highscore < score) {
            highscore = score; //Als score hoger is dan highscore, word score de highscore.
        }
        highscoretext.text = highscore.ToString();
        //Highscore word geprint naar de UI
    }

   
}