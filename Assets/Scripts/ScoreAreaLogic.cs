﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaLogic : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        ScoreLogic.score++;    
    }
}
