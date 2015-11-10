using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class atras : MonoBehaviour {

    public void back(string levelName)
    {
        Application.LoadLevel("Smcinco");
    }
    public void back1(string levelName)
    {
        Application.LoadLevel("Mic");
    }
}
