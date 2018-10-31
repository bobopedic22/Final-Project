using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowballspawner : MonoBehaviour {
    public Transform _Gun;
    public GameObject _Snowball;
    public Rigidbody _Gunrb;
    public float thrust = 10;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Spawnsnowball();
        }
        

        

        
    }



    public void Spawnsnowball()
    {
        Instantiate(_Snowball,_Gun);
       _Gunrb = _Snowball.GetComponent<Rigidbody>();
        _Gunrb.AddForce(transform.forward * thrust);
    }

}
