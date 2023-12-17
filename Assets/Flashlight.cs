using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;

    void Update()
    {

        light.enabled = isOn;
        if(Input.GetKey(KeyCode.E)) 
        { 
            Switch();
        }
    }

    void Switch()
    {
        isOn = !isOn;
    }
}
