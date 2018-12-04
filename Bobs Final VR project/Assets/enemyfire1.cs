using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire1 : MonoBehaviour
{

    [SerializeField]
    public Rigidbody projectile;
    public float speed = 15;
    public float nextFire;
    public int timer;

    float fireRate;
    public AudioClip shootSound;
    private AudioSource Source;
    private float volLowRange = .5f;
    private float volhighRange = 1.0f;
    // Use this for initialization
    void Awake()
    {
        Source = GetComponent<AudioSource>();
        fireRate = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Source.PlayOneShot(shootSound, 1f);
            nextFire = Time.time + 13f;
            ++timer;
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }

    }

}

