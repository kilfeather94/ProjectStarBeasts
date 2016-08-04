using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponManager : MonoBehaviour {

    public List<GameObject> WeaponList = new List<GameObject>();

    public WeaponProperties ActiveWeapon;

    public int MaxCarryingWeapons = 6;

    public int weaponNumber = 0;

    SpriteRenderer rend;



    public enum WeaponType
    {
        Revolver,
        ShotGun       
    }

    public WeaponType weaponType;

    public GameObject Weapon;

    Animator anim;


    void Start ()
    {
        //ActiveWeapon = WeaponList[weaponNumber].gameObject;
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    void Update ()
    {

      

        if (Input.GetKeyDown("1"))
        {
            // SelectWeapon(0);
           // weaponNumber = 0;         
            anim.SetInteger("Weapon_ID", 0);           
        }
        if(Input.GetKeyDown("2"))
        {
            //  SelectWeapon(1);
           // weaponNumber = 1;
            anim.SetInteger("Weapon_ID", 1);
        }
        
        ActiveWeapon = WeaponList[weaponNumber].GetComponent<WeaponProperties>();

    }


    void SelectWeapon(int index)
    {
        /*
        foreach(Sprite obj in WeaponSprites)
        {
            obj.SetActive(false);
            WeaponList[index].SetActive(true);
         
        }
        */
    }
    
}
