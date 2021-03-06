using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staattisetkolikotkoodi1 : MonoBehaviour
{
    //määritellään koodivarasto
    private GameObject koodit = null;
    void Start()
    {
        //haetaan koodivarasto valmiiksi
        this.koodit = GameObject.Find("koodivarasto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //onko törmääjä pantteri?
        if (collision.name.Equals("sankari"))
        {
            Debug.Log("SAIT KIINNI!");
            //efektin soitto
            GameObject.Find("aaniolio").GetComponents<AudioSource>()[1].Play();
            //päivitetään raha-laskuri
            this.koodit.GetComponent<pisteidenhallintakoodi1>().kolikot += 1;
            Destroy(this.gameObject);
        }//if
    }//OntriggerEnter2D
}
