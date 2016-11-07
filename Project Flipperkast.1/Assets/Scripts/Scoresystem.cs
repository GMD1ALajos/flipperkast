using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoresystem : MonoBehaviour
{

    public int score;
    public Text scoretext;
    public Text highscoretext;

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
    }

   
}