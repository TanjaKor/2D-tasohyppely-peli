using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lis‰t‰‰n UI-komponentit
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pisteidenhallintakoodi1 : MonoBehaviour
{
    // yll‰pidet‰‰n el‰m‰n m‰‰r‰‰
    public float elamalaskuri = 300f;

    // tallenetaan ker‰tyt kolikot
    public int kolikot = 0;

    // m‰‰ritell‰‰n el‰m‰-teksti
    private GameObject elamat = null;

    // m‰‰ritell‰‰n rahat-teksti
    private GameObject rahulit = null;
    void Start()
    {
        this.elamat = GameObject.Find("elama");
        this.rahulit = GameObject.Find("rahat");
    } //start

    void Update()
    {
        // v‰hennet‰‰n el‰m‰laskuria
        this.elamalaskuri -= Time.deltaTime * 10f;
        this.elamat.GetComponent<Text>().text = "ELƒMƒ: " + this.elamalaskuri.ToString("0");

        this.rahulit.GetComponent<Text>().text = "RAHAT: " + this.kolikot.ToString("0") + "$";

        //el‰m‰pisteiden p‰‰ttyess‰ gameover
        if (elamalaskuri < 0)
        {
            //tallennetaan ker‰tyt kolikot
            PlayerPrefs.SetInt("summa", this.kolikot);

            //siirryt‰‰n gameover-sceneen
            SceneManager.LoadScene("GameOverScene");
        }

    } // update
} // class
