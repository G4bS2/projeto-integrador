using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ou TMPro se estiver usando TextMeshPro
using UnityEngine.SceneManagement;



    [System.Serializable]
public class DialogueLine

{
    public string nextSceneName;
    public string speaker; // "A" ou "B"
    public string text;
}

public class DialogueManager : MonoBehaviour
{
    public string nextSceneName;
    public GameObject leftPanel;
    public GameObject rightPanel;

    public Text leftText;
    public Text rightText;

    public DialogueLine[] dialogueLines;
    private int currentLine = 0;

    void Start()
    {
        ShowNextLine();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowNextLine();
        }
    }

    void ShowNextLine()
    {
        if (currentLine >= dialogueLines.Length)
{
    leftPanel.SetActive(false);
    rightPanel.SetActive(false);
    
    // Carregar a próxima cena
    SceneManager.LoadScene(nextSceneName);
    return;
}

        DialogueLine line = dialogueLines[currentLine];

        if (line.speaker == "A")
        {
            leftPanel.SetActive(true);
            rightPanel.SetActive(false);
            leftText.text = line.text;
        }
        else
        {
            leftPanel.SetActive(false);
            rightPanel.SetActive(true);
            rightText.text = line.text;
        }

        currentLine++;
    }
}

