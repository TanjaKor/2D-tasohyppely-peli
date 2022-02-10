using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lis‰t‰‰n ui k‰ytett‰v‰ksi
using UnityEngine.UI;

public class gameoverkoodi1 : MonoBehaviour
{
   
    void Start()
    {
        //tallennetun summan haku ja tulostus
        int summa = PlayerPrefs.GetInt("summa");
        GameObject.Find("Pisteet").GetComponent<Text>().text = "Ker‰tyt kolikot: " + summa.ToString("0") + "$";
    } // start
} // class
