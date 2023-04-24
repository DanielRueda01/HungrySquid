using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    private bool morir;
    public GameOver gameManager;


    public int salud;
    public int vidaMaxima = 5;

    public SpriteRenderer playerSr;
    public playerMOV playermov;

    // Start is called before the first frame update
    void Start()
    {
        salud = vidaMaxima;
    }

    public void RecibirDano(int cantidad)
    {

        salud -= cantidad;
        if (salud <= 0 && !morir)
        {
            playerSr.enabled = false;
            playermov.enabled = false;

            morir = true;
            gameManager.gameOver();

        }

    }

}
