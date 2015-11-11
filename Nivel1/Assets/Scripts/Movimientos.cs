using UnityEngine;
using System.Collections;

public class Movimientos : MonoBehaviour
{


    public float maxSpeed = 3;
    public float Velocidad = 50f;
    public float Salto = 150f;

    private Rigidbody2D rb2d;    


    void Start ()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * Salto);
        }
	}

    void FixedUpdate()
    {
    
            float h = Input.GetAxis("Horizontal");
            rb2d.AddForce((Vector2.right * Velocidad) * h);

            if (rb2d.velocity.x > maxSpeed)
            {
                rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
            }   
    }
}

