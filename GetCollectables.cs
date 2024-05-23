using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollectables : MonoBehaviour
{
    // Recordar que cuando yo creo variables públicas puedo editarlas en la interfaz 
    public int scoreCollectables; // Un entero del puntaje: aquí me lo va a acumular 

    public AudioSource audioAetherita; // Variable para el audio de Aetherita

    // Start es llamado antes de la primera actualización del frame
    void Start()  // Start es la función que se ejecuta cuando uno le da play 
    {
        scoreCollectables = 0;
    }

    // Update es llamado una vez por frame
    void Update()
    {
        // No se necesita código aquí de momento
    }

    void OnTriggerEnter2D(Collider2D col) // Solo necesitamos que el código se ejecute cuando el personaje choque con los colisionables 
    {
        if (col.gameObject.name.Contains("Aetherita"))
        {
            Destroy(col.gameObject);  // Destruyo el gameobject porque el coleccionable solo debe dar puntos una vez
            scoreCollectables += 14;  // Le sumo 14 a la variable de puntos 
            Debug.Log("Score collectables: " + scoreCollectables.ToString());

            if (audioAetherita != null)
            {
                audioAetherita.Play();  // Reproduzco el sonido de la Aetherita
            }
            else
            {
                Debug.LogWarning("No se ha asignado un AudioSource para audioAetherita");
            }
        }
    }
}
