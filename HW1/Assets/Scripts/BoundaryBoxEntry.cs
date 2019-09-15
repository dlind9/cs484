using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryBoxEntry : MonoBehaviour
{
    public int somethingEntered;
    public Collider player;
    public TextBoxManager currentTextBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        somethingEntered = 0; 
        if(other.name == "Player")
        {
            currentTextBox.ReloadScript(1, 2);
            currentTextBox.EnableTextBox();
            somethingEntered = 2;
        }
        else
        {
            somethingEntered = 1;
        }
    }
}
