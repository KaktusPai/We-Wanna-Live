using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightbutton : MonoBehaviour
{
    bool clicked = false;
    void Start()
    {
        var cubeRenderer = this.GetComponent<Renderer>();
        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
    void Update()
    {
        var cubeRenderer = this.GetComponent<Renderer>();

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 2f))
            {
                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                clicked = !clicked;

                if (clicked == true)
                {
                    cubeRenderer.material.SetColor("_Color", Color.green);
                    managerscript.rightNumbers += 1;
                }
                else
                {
                    cubeRenderer.material.SetColor("_Color", Color.red);
                    managerscript.rightNumbers -= 1;
                }
            }
        }
    }

    /* void OnMouseDown()
     {
         clicked = !clicked;
         var cubeRenderer = this.GetComponent<Renderer>();
         if (clicked == true)
         {
             cubeRenderer.material.SetColor("_Color", Color.green);
             managerscript.rightNumbers += 1;
         }
         else
         {
             cubeRenderer.material.SetColor("_Color", Color.red);
             managerscript.rightNumbers -= 1;
         }
     }*/
}
