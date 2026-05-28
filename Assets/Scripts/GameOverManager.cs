using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject panelMuerte;
    public GameObject panelVictoria;

    public bool tieneItemEspecial = false;

    // PUNTOS ACTUALES
    public int puntosHongos = 0;
    public int puntosDiamantes = 0;
    public int puntosTotales = 0;

    // METAS PARA GANAR
    public int metaHongos = 150;
    public int metaDiamantes = 100;

    public TextMeshProUGUI textoHongos;
    public TextMeshProUGUI textoDiamantes;
    public TextMeshProUGUI textoTotal;

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
            metaHongos;

        textoDiamantes.text =
            "Diamantes: " +
            puntosDiamantes +
            "/" +
            metaDiamantes;

        textoTotal.text =
            "Puntos Totales: " +
            puntosTotales;
    }

    public void VerificarVictoria()
    {
        Debug.Log(
            "Hongos: " + puntosHongos +
            " | Diamantes: " + puntosDiamantes +
            " | Item: " + tieneItemEspecial
        );

        if (
            puntosHongos >= metaHongos &&
            puntosDiamantes >= metaDiamantes &&
            tieneItemEspecial
        )
        {
            panelVictoria.SetActive(true);

            Time.timeScale = 0f;

            Debug.Log("¡VICTORIA!");
        }
    }
}


