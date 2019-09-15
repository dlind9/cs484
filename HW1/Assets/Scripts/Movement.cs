using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 2.0f;
    public  TextBoxManager currentTextBox;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-1.755381f, -2.619476f, -9.59f);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
            if (transform.position.x <= -1.819063f)
            {
                transform.position += Vector3.left * 0 * Time.deltaTime;
                currentTextBox.ReloadScript(0, 1);
                currentTextBox.EnableTextBox();
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
            if (transform.position.x >= 38.57726f)
            {
                transform.position += Vector3.right * 0 * Time.deltaTime;
                currentTextBox.ReloadScript(0, 1);
                currentTextBox.EnableTextBox();
            }
            if (transform.position.x > 28.24835 && transform.position.x <28.4)
            {
                currentTextBox.ReloadScript(1, 2);
                currentTextBox.EnableTextBox();
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (transform.position.x > 34.75394 && transform.position.x < 34.85)
            {
                currentTextBox.ReloadScript(2, 6);
                currentTextBox.EnableTextBox();
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            
            else
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
            if(transform.position.y >= -1.451541)
            {
                transform.position += Vector3.up * 0;
                currentTextBox.ReloadScript(0, 1);
                currentTextBox.EnableTextBox();
            }
            else
            {
                transform.position += Vector3.up * speed/2 * Time.deltaTime;
            }
			
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
            if (transform.position.y <= -2.698135)
            {
                transform.position += Vector3.down * 0 * Time.deltaTime;
                currentTextBox.ReloadScript(0, 1);
                currentTextBox.EnableTextBox();
            }
            else
            {
                transform.position += Vector3.down * speed / 2 * Time.deltaTime;
            }
		}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
