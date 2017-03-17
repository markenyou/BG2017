﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Brick : MonoBehaviour {

    public int health = 2;

    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        health -= 1;
        if(health == 0){
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().IBrokeABrick();
            FindObjectOfType<BallLevel2>().IBrokeABrick();
        }
    }
    
    
}
