﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToLmao(){
        SceneManager.LoadScene("lmao");
    }

    public void goToTitle(){
        SceneManager.LoadScene("TitleScreen");
    }
}
