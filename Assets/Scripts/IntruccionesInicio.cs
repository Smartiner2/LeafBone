using UnityEngine;

public class InstruccionesInicio : MonoBehaviour
{
    public GameObject panelInstrucciones;

    void Start()
    {
        // Mostrar instrucciones
        panelInstrucciones.SetActive(true);

        // Pausar juego
        Time.timeScale = 0f;
    }

    public void EmpezarJuego()
    {
        // Ocultar instrucciones
        panelInstrucciones.SetActive(false);

        // Reanudar juego
        Time.timeScale = 1f;
    }
}
