﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField inputpassword;
    public string password = "Maia";
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChechPassword()
    {
        if (inputpassword.text == password)
        {
            Debug.Log("Tiene acceso ");
            
        }
        else
        {
            Debug.Log("Acceso denegado");
        }
    }
}
