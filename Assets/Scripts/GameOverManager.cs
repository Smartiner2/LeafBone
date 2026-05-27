using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject panelMuerte;
    public GameObject panelVictoria;
    
    public bool tieneItemEspecial = false;


    public int puntosHongos = 150;
    public int puntosDiamantes = 100;
    public int puntosTotales;

    public TextMeshProUGUI textoHongos;
    public TextMeshProUGUI textoDiamantes;
    public TextMeshProUGUI textoTotal;


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

        ActualizarHUD();

        VerificarVictoria();
    }

    public void SumarDiamante(int puntos)
    {
        puntosDiamantes += puntos;
        puntosTotales += puntos;


        ActualizarHUD();

        VerificarVictoria();
    }

    void ActualizarHUD()
    {
        textoHongos.text =
            "Hongos: " +
            puntosHongos +
            "/" +
            totalHongos;

        textoDiamantes.text =
            "Diamantes: " +
            puntosDiamantes +
            "/" +
            totalDiamantes;

        textoTotal.text =
            "Puntos Totales: " +
            puntosTotales;
    }

    void VerificarVictoria()
    {
        if (
        puntosHongos >= 150 &&
        puntosDiamantes >= 100 &&
        tieneItemEspecial)
        {
            panelVictoria.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("¡VICTORIA!");
        }
    }



}


