﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 100;
    public Material material;
    public GameObject destroyGameObject;

    private void Start()
    {
        GetComponent<Renderer>().material = material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Add score to game
        if(collision.gameObject.CompareTag("Projectile"))
        {
            Game.Instance.AddPoints(points);
            if (destroyGameObject != null)
            {
                Destroy(destroyGameObject);
            }
        }
    }
}
