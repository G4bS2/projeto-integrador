using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Prologue"); // Substitua pelo nome real da cena do jogo
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Jogo encerrado."); // Funciona só em builds
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
