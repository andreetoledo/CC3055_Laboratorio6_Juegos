﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
  


    // Start is called before the first frame update
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

   
}
