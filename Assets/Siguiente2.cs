using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Siguiente2 : MonoBehaviour {
    public void Polar2(string levelName)
    {
        Application.LoadLevel("Polar2");
    }

    public void ExitApplication(string levelName)
    {
        Application.LoadLevel("MenuIni");
    }


    public void Frecuencia2(string levelName)
    {
        Application.LoadLevel("Frecuencia2");
    }
}
