using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastClick : MonoBehaviour
{

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "ButtonTag")
            {
                Debug.Log("Hovering over button");

                if (Input.GetButtonDown("Fire1"))
                {
                    hit.collider.SendMessageUpwards("ToggleActive");

                    Debug.Log("Clicked " + hit.transform.name);
                }
            }
            if (hit.collider.tag == "TelephoneTag")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    hit.collider.SendMessageUpwards("Teleport");
                }
            }
        }
    }
}
