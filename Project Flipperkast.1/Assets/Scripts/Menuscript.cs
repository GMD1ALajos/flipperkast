using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    //hier worden de variabellen toegewezen
    public Canvas gameui;
    public Canvas mainmenu;
    public Button menu;
    public Canvas credits;
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
        gameui.enabled = false;             //Deze canvassen staan momenteel uit (anders krijg je overlappende beelden en teksten)
        credits.enabled = false;


    }

    public void PlayPress()             //Hier wordt aangegeven wat er op dit moment aan of uit staat (true en false) zodra de knop word ingedrukt.

    {
        gameui.enabled = true; 
        mainmenu.enabled = false;
        credits.enabled = false;
        start.enabled = false;
        quit.enabled = false;
        back.enabled = false;
        menu.enabled = true;
    }

    public void PlayCredits()       //Via de knop credits zie je alleen de credits canvas

    {
        gameui.enabled = false;
        mainmenu.enabled = false;
        credits.enabled = true;
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
        start.enabled = true;
        quit.enabled = true;
        back.enabled = false;
        menu.enabled = false;
    }
    

    public void ExitGame()
    {
        Application.Quit(); //dit betekend dat de game/het programma word afgesloten.
    }

}