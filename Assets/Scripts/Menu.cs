using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuPrincipal;
    public GameObject Configuracion;
    public GameObject Creditos;

    public void OpenMenuPrincipalPanel()
    {
        Configuracion.SetActive(false);
        MenuPrincipal.SetActive(true);
        Creditos.SetActive(false);
    }

    public void OpenConfiguracionPanel()
    {
        Configuracion.SetActive(true);
        MenuPrincipal.SetActive(false);
        Creditos.SetActive(false);
    }

    public void OpenCreditosPanel()
    {
        Configuracion.SetActive(false);
        MenuPrincipal.SetActive(false);
        Creditos.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }





}
