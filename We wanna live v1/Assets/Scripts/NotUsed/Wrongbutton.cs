using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrongbutton : MonoBehaviour
{
    bool clicked = false;
    public bool resetonce = false;
    void Start()
    {
        var cubeRenderer = this.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
    void Update()
    {
    }
    void OnMouseDown()
    {
        clicked = !clicked;
        var cubeRenderer = this.GetComponent<Renderer>();
        if (clicked == true)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);
            managerscript.wrongNumbers += 1;
        }
        else
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
            managerscript.wrongNumbers -= 1;
        }
    }
}
