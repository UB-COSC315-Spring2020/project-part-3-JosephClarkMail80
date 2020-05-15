using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    Color[] colorArray = new Color[6] { Color.red, Color.blue, Color.yellow, Color.green, Color.cyan, Color.grey };
    Color ballColor;
    Renderer rend;

    void Start()
    {
        rend = this.GetComponent<Renderer>();
        startPosition = transform.position;
        Launch(); 
    }

    public void Reset()
    {
        ChangeColor();
        rend.material.SetColor("_Color", ballColor);
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        //Code lets the ball "bounce" around
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    void ChangeColor()
    {
        //Code changes the ball's color
        Color newColor = colorArray[Random.Range(0, colorArray.Length)];
        ballColor = newColor;
    }

}
