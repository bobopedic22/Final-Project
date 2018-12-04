using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenereset : MonoBehaviour {
 
 private void OnCollisionEnter(Collision snowball)
{
    if (snowball.gameObject.name == "resetcube")
    {
        SceneManager.LoadScene("UI for snowball fight");
    }
}
// Use this for initialization
void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
