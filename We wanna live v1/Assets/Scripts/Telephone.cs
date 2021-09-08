using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone : MonoBehaviour
{
    public GameObject player;
    public bool inRoom1;
    public Transform spawn1;
    public Transform spawn2;

    void Update()
    {

    }
    public void Teleport()
    {
        if (managerscript.calls > 0)
        {
            if (inRoom1 == true)
            {
                Debug.Log("TP to 2");
                player.GetComponent<CharacterController>().enabled = false;
                player.transform.position = spawn2.transform.position;
                player.GetComponent<CharacterController>().enabled = true;
                managerscript.calls -= 1;
            }
            else
            {
                Debug.Log("TP to 1");
                player.GetComponent<CharacterController>().enabled = false;
                player.transform.position = spawn1.position;
                player.GetComponent<CharacterController>().enabled = true;
                managerscript.calls -= 1;
            }
        }
    }
}