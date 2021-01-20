using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0.1f;
    private int ammo = 100;
    private float fireTimer = 0;

    public Bullet bullet;

    void Start()
    {
        
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    Bullet bullet = Instantiate(this.bullet, transform.position, Quaternion.identity);
        //    bullet.Fire(ray.direction);
        //}
    }

    public bool Fire(Vector3 position, Vector3 direction)
    {
        if(fireTimer >= fireRate)
        {
            fireTimer = 0;
            Bullet bullet = Instantiate(this.bullet, position, Quaternion.identity);
            bullet.Fire(direction);

            return true;
        }

        return false;
    }
}
