using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class generatePNG : MonoBehaviour
{
    public SpriteRenderer sprite;
    private Sprite temp;
    // Start is called before the first frame update
    void Start()
    {
        int nx = 200;
        int ny = 100;
        string path = "Assets/Resources/image.png";
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine("P3\n" + nx + " " + ny + "\n255\n");
        for(int i = 0; i<= ny-1; ++i)
        {
            for(int j=0; j<nx; ++j)
            {
                float r = (float)j / (float)nx;
                float g = (float)i / (float)ny;
                float b = .2f;
                int ir = (int)(255.99 * r);
                int ig = (int)(255.99 * g);
                int ib = (int)(255.99 * b);
                writer.WriteLine(ir + " " + ig + " " + ib + "/n");
            }
        }
        Debug.Log("PNG finished");
        writer.Close();
        //AssetDatabase.Refresh();
        temp = Resources.Load<Sprite>("image");
        sprite.sprite = temp;
        //AssetDatabase.Refresh();
    }
}
