using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject panelMuerte;

    public void MostrarPantallaMuerte()
    {
        panelMuerte.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    public void IrMenuPrincipal()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MenuPrincipal");
    }
}


