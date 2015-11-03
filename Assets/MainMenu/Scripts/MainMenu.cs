using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


    public Texture backgroundTexture;
    public float guiPlacementY1;
    public float guiPlacementY2;
    public float guiPlacementY3;
    

    void OnGUI()
    {

        //Display Background
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
    

        //Display Buttons
        if (GUI.Button (new Rect(Screen.width*.5f, Screen.height*.5f, Screen.width*.4f, Screen.height*.1f),"Jugar"))
        {
            print("Clicked Pay Game");
        }

        if (GUI.Button(new Rect(Screen.width * .5f, Screen.height * guiPlacementY1, Screen.width * .4f, Screen.height * .1f), "Ingresar Información"))
        {
            Application.LoadLevel("Registro");
        }

        if (GUI.Button(new Rect(Screen.width * .5f, Screen.height * guiPlacementY2, Screen.width * .4f, Screen.height * .1f), "Opciones"))
        {

        }

        if (GUI.Button(new Rect(Screen.width * .5f, Screen.height * guiPlacementY3, Screen.width * .4f, Screen.height * .1f), "Salir"))
        {
            Application.Quit();
        }

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
