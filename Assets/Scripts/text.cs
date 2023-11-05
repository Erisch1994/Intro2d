using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class text : MonoBehaviour
{

    [Space(5)]
    [Header("Toggle Gui On/Off")]
    public bool GuiOn;


    [Space(5)]
    [Header("On trigger text")]
    public string Text = "Turn Back";

    public Rect BoxSize = new Rect(0, 0, 600, 300);


    [Space(5)]
    public GUISkin customSkin;

    void OnTriggerEnter2D()
    {
        GuiOn = false;
    }


    void OnTriggerExit2D()
    {
        GuiOn = true;
    }

    void OnGUI()
    {

        if (customSkin != null)
        {
            GUI.skin = customSkin;
        }

        if (GuiOn == true)
        {

            GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));

            GUI.Label(BoxSize, Text);
            GUI.EndGroup();

        }


    }

}