using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerprefs : MonoBehaviour
{
    public void playerPrefs()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.SetInt("TOTAL COIN", 0);
    }
}
