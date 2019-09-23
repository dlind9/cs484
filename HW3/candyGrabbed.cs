using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyGrabbed : MonoBehaviour
{
    public candyCounter candyCounter;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        candyCounter.candyGrabbed();
        Destroy(this.gameObject);
        Debug.Log("Candy grabbed");
    }
}
