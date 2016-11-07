using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    //hier worden de variabellen toegewezen
    public Canvas gameui;
    public Canvas mainmenu;
    public Canvas credits;
    public Canvas Gameover;
    public Button menu;
    public Button start;
    public Button quit;
    public Button back;

    // Use this for initialization
    void Start()
    {
        //Alle variabellen krijgen hier een component toegewezen die via de inspector moet worden aangegeven.
        gameui = gameui.GetComponent<Canvas>();
        mainmenu = mainmenu.GetComponent<Canvas>();
        credits = credits.GetComponent<Canvas>();
        start = start.GetComponent<Button>();
        quit = quit.GetComponent<Button>();
        back = back.GetComponent<Button>();
        menu = menu.GetComponent<Button>();
        gameui.enabled = false;             //Dit canvas staat momenteel uit (anders krijg je overlappende beelden en teksten)
        credits.enabled = false;            //Dit canvas staat momenteel uit (anders krijg je overlappende beelden en teksten)
        Gameover.enabled = false;           //Dit canvas staat momenteel uit (anders krijg je overlappende beelden en teksten)


    }

    public void PlayPress()             //Hier wordt aangegeven wat er op dit moment aan of uit staat (true en false) zodra de knop word ingedrukt.

    {
        gameui.enabled = true;          //Dit canvas staat aan
        mainmenu.enabled = false;       //Dit canvas staat uit
        credits.enabled = false;        // Dit canvas staat uit
        Gameover.enabled = false;       // Dit canvas staat uit
        start.enabled = false;
        quit.enabled = false;
        back.enabled = false;
        menu.enabled = true;
        GameObject.Find("Barrier").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("Barrier").GetComponent<MeshRenderer>().enabled = false;
        //Er staat een  "barrier" voor de pinball zodat de speler niet al kan spelen, de barrier verdwijnt zodra de knop Play ingedrukt is.

    }

    public void PlayCredits()       //Via de knop credits zie je alleen de credits canvas

    {
        gameui.enabled = false;
        mainmenu.enabled = false;
        credits.enabled = true;
        Gameover.enabled = false;
        start.enabled = false;
        quit.enabled = false;
        back.enabled = true;
        menu.enabled = false;
    }

    public void PlayBack()
    {
        gameui.enabled = false;
        mainmenu.enabled = true;
        credits.enabled = false;
        Gameover.enabled = false;
        start.enabled = true;
        quit.enabled = true;
        back.enabled = false;
        menu.enabled = false;

    }

    public void Playmenu()
    {
        gameui.enabled = false;
        mainmenu.enabled = true;
        credits.enabled = false;
        Gameover.enabled = false;
        start.enabled = true;
        quit.enabled = true;
        back.enabled = false;
        menu.enabled = false;
        GameObject.Find("Barrier").GetComponent<BoxCollider>().enabled = true;
        GameObject.Find("Barrier").GetComponent<MeshRenderer>().enabled = true;

    }

    public void PlayGameover()
    {
        gameui.enabled = false;
        mainmenu.enabled = false;
        credits.enabled = false;
        Gameover.enabled = true;
        start.enabled = false;
        quit.enabled = true;
        back.enabled = true;
        menu.enabled = false;
        GameObject.Find("WallBumpL").GetComponent<ScoreCount>().score = 0;
        GameObject.Find("WallBumpR").GetComponent<ScoreCount>().score = 0;
        GameObject.Find("BumperLeft").GetComponent<ScoreCount>().score = 0;
        GameObject.Find("BumperRight").GetComponent<ScoreCount>().score = 0;
        GameObject.Find("BumperTop").GetComponent<ScoreCount>().score = 0;
        //Alle score worden weer op 0 gezet nadat het menu weer open is.
        GameObject.Find("Barrier").GetComponent<BoxCollider>().enabled = true;
        GameObject.Find("Barrier").GetComponent<MeshRenderer>().enabled = true;
        //Zodra het spel Game Over is herstellen de barrier collider en renderer (zodat de speler niet verder kan spelen.
        
    }


    public void ExitGame()
    {
        Application.Quit(); //dit betekend dat de game/het programma word afgesloten.
    }

}