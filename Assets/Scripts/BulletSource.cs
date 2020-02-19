﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSource : MonoBehaviour
{
    public float fireRate = 2f;
    public float chanceToChangeDirections = 0.1f;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 2f, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }

    void Fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab) as GameObject;
        Bullet.transform.position = transform.position;

    }
}
}
