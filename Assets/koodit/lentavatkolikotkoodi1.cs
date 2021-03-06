using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lentavatkolikotkoodi1 : MonoBehaviour
{
    //nopeus
    private float nopeus = 1f;
    //määritellään paukulle objekti
    public GameObject paukku = null;
    //määritellään koodivarasto
    private GameObject koodit = null;

        void Start()
    {
        //Arvotaan lentonopeus
        this.nopeus = Random.Range(0.5f, 5f);

        //haetaan koodivarasto valmiiksi
        this.koodit = GameObject.Find("koodivarasto");
    } // start

    
    void Update()
    {
        // lennätetään kolikot
        this.GetComponent<Transform>().Translate(-this.nopeus * Time.deltaTime, 0f, 0f);

        // tuhotaan läpikulkeneet kolikot
        if ((this.GetComponent<Transform>().position.x < -10) || (this.GetComponent<Transform>().position.x > 11))
        {
            Destroy(this.gameObject);
        } //if
    } // update

    //reagointi triggeriin
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //onko törmääjä pantteri?
        if (collision.name.Equals("sankari"))
        {
            Debug.Log("SAIT KIINNI!");
            //efektin soitto
            GameObject.Find("aaniolio").GetComponents<AudioSource>()[1].Play();

            //päivitetään raha-laskuri
            this.koodit.GetComponent<pisteidenhallintakoodi1>().kolikot += 5;

            //Luodaan räjähdysanimaatio
            GameObject apupaukku = Instantiate(this.paukku, this.GetComponent<Transform>().position, Quaternion.identity);

            //tuhotaan räjähdysolio 5s kuluttua ja kolikko törmäyksessä välittömästi
            Destroy(apupaukku, 5f);
            Destroy(this.gameObject);
        }//if
    }//OntriggerEnter2D
} //class
