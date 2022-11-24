using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Variablen deklarieren
    public GameObject player;
    public Rigidbody2D rb;
    public float ballSpeed;
    public bool gameStarted = false;
    public Vector2 offset = new Vector2(0, 0.4f);

    void Update()
    {
        // Den Ball los schießen, um das Spiel zu starten
        if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false)
        {
            rb.AddForce(Vector2.up * ballSpeed);
            gameStarted = true;
        }

        // Der Ball befindet sich an der Position des Spielers, solange das Spiel noch nicht begonnen hat
        if(gameStarted == false)
        {
            transform.position = (Vector2)player.transform.position + offset;
        }        
    }

    // Wenn der Ball mit einem Brick kollidiert, das Brick zerstören
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
        
    }

    // Wenn der Ball den Trigger an der unteren Wand auslöst, wird die GameOver-Funktion ausgeführt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
    }
}
