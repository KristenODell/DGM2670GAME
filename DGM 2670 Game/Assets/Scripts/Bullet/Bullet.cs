using UnityEngine;
using System.Collections;
using System;

public class Bullet : PowerUpBase
{
    public int wait = 5;
    Vector3 tempPos;

    public static Action<float> Shooting;

    public IEnumerator Shoot()
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(wait);
        gameObject.SetActive(false);
    }

	// Use this for initialization
	void Start ()
    {
        Shooting = ShootingHandler;
        gameObject.SetActive(false);
	}

    public void ShootingHandler(float bulletSpeed)
    {
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            tempPos.x = bulletSpeed;
            StartCoroutine(Shoot());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            tempPos.z = bulletSpeed;
            StartCoroutine(Shoot());
        }
    }
	
}
