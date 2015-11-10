using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SIGUIENTE : MonoBehaviour {
    public void Polar(string levelName)
    {
        Application.LoadLevel("Polar");
    }

    public void ExitApplication(string levelName)
    {
        Application.LoadLevel("MenuIni");
    }


    public void Frecuencia(string levelName)
    {
        Application.LoadLevel("Frecuencia");
    }
  
}
