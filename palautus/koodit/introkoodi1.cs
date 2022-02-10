using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//scenemanager
using UnityEngine.SceneManagement;
public class introkoodi1 : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(GameObject.Find("introaaniolio"));
    } // start

    void Update()
    {
        //k‰ytt‰j‰n painaessa jotain n‰pp‰int‰, siirryt‰‰n itse peliin
        if (Input.anyKey)
        {
            SceneManager.LoadScene("PaaScene");
        } // if
    } // update
} //class
