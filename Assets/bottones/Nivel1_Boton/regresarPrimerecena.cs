using UnityEngine;
using UnityEngine.SceneManagement;

public class regresar : MonoBehaviour
{
    public void RegresarEscena()
    {
        SceneManager.LoadScene("PrimeraScena");
    }
}
