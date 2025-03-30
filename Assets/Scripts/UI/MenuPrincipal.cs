using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal: MonoBehaviour
{
    private void Update()
    {
        
    }

    public void StartPlaying()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
