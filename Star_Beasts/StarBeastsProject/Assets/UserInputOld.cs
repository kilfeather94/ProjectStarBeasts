using UnityEngine;
using System.Collections;

public class UserInputOld : MonoBehaviour {


    //Temporary
    public Transform bulletSpawn;
    public GameObject particle;

    Animator anim;

    

	// Use this for initialization
	void Start ()
    {
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetButtonDown("Fire1"))
        {
            GameObject go = (GameObject)Instantiate(particle, bulletSpawn.position, bulletSpawn.rotation);
            anim.SetTrigger("fire");
        }
	}
}
