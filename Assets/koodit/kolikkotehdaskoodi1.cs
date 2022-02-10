using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolikkotehdaskoodi1 : MonoBehaviour
{   
    //määritellään objekti prefabille
    public GameObject kolikko = null;

    private float laskuri = 0f;
    void Start()
    {
        
    } //start

    
    void Update()
    {
        
        this.laskuri += Time.deltaTime;

        if (this.laskuri > 0.3f)
        {
            //luodaan uusia kolikoita lennosta
            GameObject apukolikko = Instantiate(this.kolikko, new Vector3(Random.Range(10f, 14f), Random.Range(-3f, 4f), 0f),
                                                   Quaternion.identity);
            this.laskuri = 0f;
        } //if

    } //update
} //class
