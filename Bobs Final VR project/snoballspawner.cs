using UnityEngine;
using System.Collections;

public class snoballspawner : MonoBehaviour
{
    public GameObject snowballprefab;

    public Transform snowballspawn;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetButtonDown(Axis1D.Secondaryindextrigger));
        {
            fire();
        }
	} 
    void fire()
    {
        // Create the Bullet from the snowball prefab
        var snowball = (GameObject)Instantiate(
            snowballprefab,
            snowballspawn.position,
            snowballspawn.rotation);
        // Add velocity to the snowball
        snowball.GetComponent<Rigidbody>().velocity = snowball.transform.forward * 10;
        // Destroy the bullet after 10 seconds
        Destroy(snowball, 10.0f);
    }
}
