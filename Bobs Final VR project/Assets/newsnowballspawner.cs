using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsnowballspawner : MonoBehaviour
{


    public Rigidbody projectile;
    public float speed = 15;
    public float nextFire;
    public int timer;
    public AudioClip shootSound;
    private AudioSource Source;
    private float volLowRange = .5f;
    private float volhighRange = 1.0f;

    void Awake()
    {
        Source = GetComponent<AudioSource>();
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            Source.PlayOneShot(shootSound, 1f);
            nextFire = Time.time + 0.6f;
            ++timer;

            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }
}

/*
public float nextFire;
public int timer;       // in variable declaration

Time.time > nextFire && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger  // In update condition

nextFire = Time.time + 0.5f;        //In Update loop
            ++timer;
*/

    // Increase incrementation of nextFire to slow fire rate
    // Decrease incrementation of nextFire to incease fire rate