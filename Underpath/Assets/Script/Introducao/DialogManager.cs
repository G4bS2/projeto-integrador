using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ou TMPro se estiver usando TextMeshPro
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public Text textoDialogo; // ou TextMeshProUGUI se usar TMP
    private string[] falas = {
        "Olá, aventureiro!",
        "Você está prestes a começar sua jornada.",
        "Boa sorte!"
    };

    private int index = 0;

    void Start()
    {
        MostrarFala();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Clicar com o mouse ou toque
        {
            ProximaFala();
        }
    }

    void MostrarFala()
    {
        if (index < falas.Length)
        {
            textoDialogo.text = falas[index];
        }
    }

    void ProximaFala()
    {
        index++;
        if (index < falas.Length)
        {
            MostrarFala();
        }
        else
        {
            // Acabou o diálogo - pode trocar de cena, fechar painel, etc
            SceneManager.LoadScene("Game");
            Debug.Log("Fim do diálogo");
        }
    }
}
