using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Library hinzuf�gen, um mit UI-Elementen zu arbeiten
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Variablen deklarieren
    public GameObject ball;
    public Text brickText;
    private int brickCount;

    void Update()
    {
        // Anzahl der Bricks erfassen und in brickCount speichern
        brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
        // Text �ndern
        brickText.text = "BRICKS: " + brickCount;

        // Wenn keine Bricks mehr im Spiel sind, wird die Victory-Funktion ausgef�hrt
        if(brickCount == 0)
        {
            FindObjectOfType<GameManager>().Victory();
            Destroy(ball);
        }
    }
}
