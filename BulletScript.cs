using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bulletSpeed;

    public GameObject BulletPrefab;
    public Transform FirePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
    

    }

}
