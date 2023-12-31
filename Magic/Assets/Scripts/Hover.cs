﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{

    public float speed = 5f;

    public float height = 0.5f;

    private Vector3 pos;
    [SerializeField] float rotSpeed = 30f;


    void Start()
    {
        pos = transform.position;
    }
    void Update()
    {

        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        transform.Rotate(transform.forward * rotSpeed * Time.deltaTime);
    }
}
