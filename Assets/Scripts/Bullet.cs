﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float rightX = 30f;
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        if (transform.position.x> rightX)
        {
            Destroy(this.gameObject);
        }
    }
}
