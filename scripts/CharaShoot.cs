using UnityEngine;
using System.Collections;
/*
 * shoot bullets on click (firerate limited)
 * bullet direction: player -> mouseposition(touchposition)
 * attach this to player
 */
public class CharaShoot : MonoBehaviour {
    public Rigidbody2D bullet;
    public float bulletSpeed = 2f;
    Vector2 v;
    private float fireRate = 0.5f;
    private float lastShot = 0.0f;
    void Start () {
	
	}

	void Update () {
        if (Input.GetButtonDown("Fire1"))//TODO: change to touch method
        {
            Fire();
        }
    }
    public void Fire()
    {
        if (Time.time > fireRate + lastShot) 
        {
            Vector2 target = Input.mousePosition;
            v = (Vector2)Camera.main.WorldToScreenPoint(transform.position);
            Rigidbody2D b = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
            b.velocity = (target - v).normalized * bulletSpeed;
            lastShot = Time.time;
        }

    }
}
