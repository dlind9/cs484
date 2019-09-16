using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Movement : MonoBehaviour
{
    public Animator doge;
    public int rand;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0, 3);
        doge.SetFloat("chooseDirection", rand);
    }
}
