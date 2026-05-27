using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject panelPausa;

    public GameObject panelConfiguracion;

    // ABRIR PAUSA
    public void PausarJuego()
    {
        panelPausa.SetActive(true);

        Time.timeScale = 0f;

    }

    // CONTINUAR
    public void ContinuarJuego()
    {
        panelPausa.SetActive(false);

        Time.timeScale = 1f;

    }

    // ABRIR CONFIGURACIÓN
    public void AbrirConfiguracion()
    {
        panelPausa.SetActive(false);
        panelConfiguracion.SetActive(true);
    }

    public void CerrarConfiguracion()
    {
        panelConfiguracion.SetActive(false);
        panelPausa.SetActive(true);
    }


    // MENÚ PRINCIPAL
    public void VolverMenuPrincipal()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MenuPrincipal");
    }
}
