using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi : MonoBehaviour
{
    void Update()
    {
        // escill� ulos sovelluksesta
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } // if
    } //update
} // class
