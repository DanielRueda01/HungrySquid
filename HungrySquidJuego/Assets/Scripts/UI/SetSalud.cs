using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSalud : MonoBehaviour
{

    public int salud;
    public int vidaMaxima;

    public Sprite quitarCorazon;
    public Sprite corazonCompleto;
    public Image[] corazones;

    public VidaJugador vidaJugador;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        salud = vidaJugador.salud;
        vidaMaxima = vidaJugador.vidaMaxima;


        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < salud)
            {
                corazones[i].sprite = corazonCompleto;
            }
            else
            {
                corazones[i].sprite = quitarCorazon;
            }
            if(i < vidaMaxima)
            {
                corazones[i].enabled = true;
            }
            else
            {
                corazones[i].enabled = false;
            }
        }
    }
}
