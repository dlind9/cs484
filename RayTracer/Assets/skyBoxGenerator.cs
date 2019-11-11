using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class skyBoxGenerator : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite temp;
    public class Ray
    {
        public Vector3 A;
        public Vector3 B;
        public Ray()
        {

        }
        public Ray(Vector3 a, Vector3 b)
        {
            A = a;
            B = b;
        }
        public Vector3 origin()
        {
            return A;
        }
        public Vector3 direction()
        {
            return B;
        }
        public Vector3 point_at_parameter(float t)
        {
            return A + t * B;
        }

    }
    private Vector3 color(Ray r)
    {
        float t = .5f * r.direction().y + .5f;
        Vector3 N = (r.point_at_parameter(t) - new Vector3(-1.0f, -.8f, 0.0f)).normalized;
        Vector3 orange = new Vector3(1.0f, 0.0f, 0.0f);
        Vector3 green = new Vector3(0.0f, 1.0f, 0.0f);
        //return (1.0f-t) * green + t*orange;
        return .5f*(new Vector3(N.x+.5f, N.y+.5f, .0f));
    }
    private Vector3 missShader(Ray r)
    {
        float t = .5f * r.direction().y + .5f;
        return (1.0f - t) * Vector3.one + t * (new Vector3(.5f, .7f, 1.0f));    //this is the lerp
    }
    private void generate()
    {
        int nx = 200;
        int ny = 100;
        string path = "Assets/Resources/rayTest.png";
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine("P3\n" + nx + " " + ny + "\n255\n");
        Vector3 LLCorner = new Vector3(-2.0f, -1.0f, -1.0f);
        Vector3 horizontal = new Vector3(4.0f, 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, 2.0f, 0.0f);
        Vector3 origin = Vector3.zero;
        for(int i=ny-1; i>=0; --i)
        {
            for(int j=0; j<nx; ++j)
            {
                float u = (float)j / (float)nx;
                float v = (float)i / (float)ny;
                Ray r = new Ray(origin, LLCorner + u*horizontal + v*vertical);
                Vector3 col = color(r);
                int ir = (int)(255.99 * col[0]);
                int ig = (int)(255.99 * col[1]);
                int ib = (int)(255.99 * col[2]);

                writer.WriteLine(ir + " " + ig + " " + ib + "/n");
            }
        }
        writer.Close();
        //AssetDatabase.Refresh();
        temp = Resources.Load<Sprite>("rayTest");
        sprite.sprite = temp;
        //AssetDatabase.Refresh();
    }
        // Start is called before the first frame update
        void Start()
    {
        generate();
    }
}
