using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextImporter : MonoBehaviour
{
    public TextAsset textFile;
    public string[] dialogue;

    // Start is called before the first frame update
    void Start()
    {
        if(textFile != null)
        {
            dialogue = (textFile.text.Split('\n'));
        }
    }
}
