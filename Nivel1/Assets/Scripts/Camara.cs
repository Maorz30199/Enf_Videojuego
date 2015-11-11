using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour
{

    
    public Vector2 velocidad;
    public float TiemY;
    public float TiemX;

    public GameObject personaje;

	void Start ()
    {
        //personaje = GameObject.FindGameObjectWithTag("Personaje");
	}
	
	
	void Update ()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, personaje.transform.position.x, ref velocidad.x, TiemX);
        float posY = Mathf.SmoothDamp(transform.position.y, personaje.transform.position.y, ref velocidad.y, TiemY);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
