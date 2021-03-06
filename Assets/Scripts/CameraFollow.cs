﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothness;

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, smoothness);
        }
    }
}