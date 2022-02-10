using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sankarikoodi : MonoBehaviour
{
    // suunta 1= oikea 2=vasen
    private int suunta = 1;
    //hypyn voiman m‰‰rittely
    private float hyppyvoima = 430f;
    void Start()
    {
        
    } //Start

    void Update()
    {
        //oikea nuoli k‰velee oikealle ja p‰ivitt‰‰ tarvittaessa suunnan
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (suunta == 2)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 1;
            }
            this.GetComponent<Animator>().SetInteger("sankaritila", 1);
        } //if

        //n‰pp‰imen nostamalla pys‰htyy
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.GetComponent<Animator>().SetInteger("sankaritila", 0);
        } //if

        //aina kun painetaan nuolta, liikkuu myˆs eteenp‰in
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().Translate(2f * Time.deltaTime, 0f, 0f);
        } //if

          //vasemmalla nuolella k‰velee vasemmalle ja p‰ivitt‰‰ suunnan tarvittaessa
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (suunta == 1)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 2;
            }//if
            this.GetComponent<Animator>().SetInteger("sankaritila", 1);
        } //if

        // sankari hypp‰‰ vain k‰velyst‰ ja hyppyanimaatio p‰‰lle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.GetComponent<Animator>().GetInteger("sankaritila") == 1)
            {
                this.GetComponent<Animator>().SetInteger("sankaritila", 2);
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f) * this.hyppyvoima);
            }//if
        }// if

        // sankari kyykkii 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (this.GetComponent<Animator>().GetInteger("sankaritila") != 2)
            {
                this.GetComponent<Animator>().SetInteger("sankaritila", 3);
            }//if
        }// if
    } //Update

    private void OnCollisionEnter2D (Collision2D collision)
    {
        //palautetaan k‰vely hypyst‰ alastullessa
        this.GetComponent<Animator>().SetInteger("sankaritila", 1);
    } //OncollisionEnter2D

    private void OnCollisionExit2D(Collision2D collision)
    {
        //palautetaan animaatio hyppyyn, kun on ilmassa ilman hyppy‰
        this.GetComponent<Animator>().SetInteger("sankaritila", 2);
    } //OncollisionExit2D

} //class

