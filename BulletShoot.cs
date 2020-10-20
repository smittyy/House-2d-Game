using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject BulletPrefab;
    public Transform FirePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
