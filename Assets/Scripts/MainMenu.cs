using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public Texture backgroundTexture;

    void Start()
    {
        audio.Play();
    }

    void OnGUI()
    {
        // Display our background texture
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
        if(GUI.Button(new Rect(Screen.width * .3f, Screen.height * .6f, Screen.width * .2f, Screen.height * .1f), "Start Game"))
        {
            Application.LoadLevel("mainScene");
        }

        if (GUI.Button(new Rect(Screen.width * .3f, Screen.height * .7f, Screen.width * .2f, Screen.height * .1f), "Exit Game"))
        {
            Application.Quit();
        }
    }

}
