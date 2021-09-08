using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] bool active;
    public bool correctButton;

    void Start()
    {
        var cubeRenderer = this.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.red);
    }

    void Update()
    {
        var cubeRenderer = this.GetComponent<Renderer>();
        if (active == true)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);

        }
        else
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }
    public void ToggleActive()
    {
        active = !active;

        //if unactive
        if (correctButton == true && active == false)
        {
            managerscript.rightNumbers += 1;
        }
        else if(correctButton == false && active == false)
        {
            managerscript.rightNumbers -= 1;
        }
        //if active 
        if (correctButton == true && active == true)
        {
            managerscript.rightNumbers -= 1;
        }
        else if (correctButton == false && active == true)
        {
            managerscript.rightNumbers += 1;
        }
    }
}
