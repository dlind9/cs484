using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyCounter : MonoBehaviour
{
    private int maxCandy;
    public int currentCandy;
    // Start is called before the first frame update
    void Start()
    {
        maxCandy = 4;
        currentCandy = 0;
    }

    public void candyGrabbed()
    {
        if (currentCandy < 4)
        {
            currentCandy++;
        }
        else
        {
            return;
        }
    }
}
