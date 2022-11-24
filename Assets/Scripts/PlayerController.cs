using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variablen deklarieren
    public float speed;
    private float xBound = 8.15f;

    void Update()
    {
        // Spieler nach links und rechts bewegen
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * speed);

        // Spieler kann nicht aus dem Spielfeld rausfahren
        if(transform.position.x < -xBound)
        {
            transform.position = new Vector2(-xBound, transform.position.y);
        }

        if (transform.position.x > xBound)
        {
            transform.position = new Vector2(xBound, transform.position.y);
        }
    }
}
