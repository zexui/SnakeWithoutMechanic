﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovieScript : MonoBehaviour {

    float MovieTime = 0;

    // Update is called once per frame
    void Update () {
        
        MovieTime += Time.deltaTime;

        if (MovieTime >= 7.5f)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
