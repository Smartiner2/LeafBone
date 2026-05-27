using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject panelMuerte;


    public int puntosHongos;
    public int puntosDiamantes;
    public int puntosTotales;

    public TextMeshProUGUI textoHongos;
    public TextMeshProUGUI textoDiamantes;
    public TextMeshProUGUI textoTotal;

    public int hongosRecogidos;
    public int diamantesRecogidos;

    public int totalHongos;
    public int totalDiamantes;


    public static GameOverManager instance;



    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ActualizarHUD();
    }

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

    public void SumarHongo(int puntos)
    {
        puntosHongos += puntos;
        puntosTotales += puntos;

        hongosRecogidos += puntos;

        ActualizarHUD();
    }

    public void SumarDiamante(int puntos)
    {
        puntosDiamantes += puntos;
        puntosTotales += puntos;

        diamantesRecogidos += puntos;

        ActualizarHUD();
    }

    void ActualizarHUD()
    {
        textoHongos.text =
            "Hongos: " +
            hongosRecogidos +
            "/" +
            totalHongos;

        textoDiamantes.text =
            "Diamantes: " +
            diamantesRecogidos +
            "/" +
            totalDiamantes;

        textoTotal.text =
            "Puntos Totales: " +
            puntosTotales;
    }



}


