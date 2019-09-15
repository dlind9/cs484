using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    public string[] dialogue;

    public int currentLine;
    public int finalLine;
    public bool isActive;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
        //theText.text = "Bitch nugget";
        if (textFile != null)
        {
            dialogue = (textFile.text.Split('\n'));
        }
        if( finalLine == 0)
        {
            finalLine = dialogue.Length - 1;
        }
        theText.text = dialogue[currentLine];
        if(isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    void Update()
    {
        if(!isActive)
        { return; }
        theText.text = dialogue[currentLine];
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(currentLine< finalLine)
                currentLine += 1;

        }
        else if(currentLine >= finalLine)
        {
            DisableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;

    }
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
    }
    public void ReloadScript(int newCurrentLine, int newFinalLine)
    {
        currentLine = newCurrentLine;
        finalLine = newFinalLine;
    }
}
