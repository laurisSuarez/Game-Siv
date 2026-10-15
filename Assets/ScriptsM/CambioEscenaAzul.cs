
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaAzul : MonoBehaviour
{
    public string nombreEscena = "N1Actividad2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
