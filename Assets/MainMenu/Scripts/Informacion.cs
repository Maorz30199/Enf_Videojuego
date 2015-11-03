using UnityEngine;
using System.Collections;

public class Informacion : MonoBehaviour
{

    public Texture backgroundTexture;
    public float guiPlacementY1;
    public float guiPlacementY2;
    public float guiPlacementY3;
    public float guiPlacementY4;
    public float guiPlacementY5;
    public float guiPlacementY6;
    public float guiPlacementX1;
    public float guiPlacementX5;
    public float guiPlacementX6;
    public float guiPlacementX4;
    


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
        GUI.Label(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .4f, Screen.height * .1f), "Nombre:"+ PlayerPrefs.GetString("Nombre"));
        GUI.Label(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY2, Screen.width * .4f, Screen.height * .1f), "Edad:"+ PlayerPrefs.GetInt("Edad").ToString());
        GUI.Label(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY3, Screen.width * .4f, Screen.height * .1f), "Puntos: 0");
        GUI.Label(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY4, Screen.width * .4f, Screen.height * .1f), "Nivel: 1");

        if (GUI.Button(new Rect(Screen.width * guiPlacementX5, Screen.height * guiPlacementY5, Screen.width * .4f, Screen.height * .1f), "Editar"))
        {
            
            Application.LoadLevel("Informacion");
        }

        if (GUI.Button(new Rect(Screen.width * guiPlacementX6, Screen.height * guiPlacementY6, Screen.width * .4f, Screen.height * .1f), "Menu Principal"))
        {
            Application.LoadLevel("MainMenu");
        }



    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
