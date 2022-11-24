using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Librarys hinzufügen, um mit UI-Elementen und dem SceneManager zu arbeiten
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variablen deklarieren
    public bool gameIsOver;
    public Text gameOverText;
    public Text victoryText;
    public Button restartButton;

    // Aktiviert gameOverText und restartButton
    public void GameOver()
    {
        gameIsOver = true;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);       
    }

    // Aktiviert victoryText
    public void Victory()
    {
        victoryText.gameObject.SetActive(true);
    }

    // Funktion, die die Szene neu lädt, wenn man auf den restartButton klickt
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
