using UnityEngine;
using System.Collections;

public class Registro : MonoBehaviour
{

    public Texture backgroundTexture;
    public float guiPlacementY1;
    public float guiPlacementY2;
    public float guiPlacementY3;
    public float guiPlacementX1;
    public float guiPlacementX2;
    public float guiPlacementX3;
    public float guiPlacementY4;
    public float guiPlacementX4;
    public float guiPlacementY5;
    public float guiPlacementX5;
    public string textfieldstring = "Nombre";
    public string textfield2 = "Edad";


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
        
        textfieldstring = GUI.TextField(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .4f, Screen.height * .1f),textfieldstring,50);
        textfield2 = GUI.TextField(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .4f, Screen.height * .1f), textfield2, 50);

        if (GUI.Button(new Rect(Screen.width * guiPlacementX3, Screen.height * guiPlacementY3, Screen.width * .4f, Screen.height * .1f), "Guardar"))
        {
            PlayerPrefs.SetString("Nombre", textfieldstring);
            PlayerPrefs.SetInt("Edad", int.Parse(textfield2));
            Application.LoadLevel("Informacion");
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
