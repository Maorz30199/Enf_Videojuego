using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    public bool mover;
    public Transform slot;
    float x;
    float y;

    //Variables verificar tag objeto
    public GameObject script;
    Aciertos modificar;
    public string tagObjeto; // modificar los aciertos

    //Mostrar imagen de gana

    

	void Start ()
    {
        mover = true;

        tagObjeto = gameObject.tag;

        modificar = script.GetComponent<Aciertos>();

        

        
    }

    void Update()
    {
        if(modificar.puntos == 8)
        {
            mover = false;
            Application.LoadLevel("Templo4");          
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagObjeto)
        {
            modificar.puntos += 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == tagObjeto)
        {
            modificar.puntos -= 1;
        }
    }

    void OnMouseUp()
    {
        if(mover == true)
        {
            if(Vector3.Distance (transform.position, slot.position) == 1)
            {
                x = transform.position.x;
                y = transform.position.y;

                transform.position = new Vector3(slot.position.x, slot.position.y, 0);

                slot.position = new Vector3(x, y, 0);
            }

        }
    }


}
