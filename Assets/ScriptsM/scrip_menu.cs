
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrip_menu : MonoBehaviour
{
    public int numeroEscena;

    // Función del cambio de escena
    public void Jugar()
    {
        SceneManager.LoadScene(numeroEscena);
    }

}
// Es el lenguaje principal utilizado en el motor de juegos Unity
