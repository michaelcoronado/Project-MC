using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MENUPRINC : MonoBehaviour {
public void Smcinco(string level)
    {
        Application.LoadLevel("Smcinco");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }


    public void Mic(string level)
    {
        Application.LoadLevel("Mic");
    }
    public void UUSB(string level)
    {
        Application.OpenURL("http://www.usbbog.edu.co/");
    }
    public void Sonido(string level)
    {
        Application.OpenURL("http://www.usbbog.edu.co/facultad-ciencias-basicas-ingenieria-3/ingenieria-de-sonido");
    }
}

