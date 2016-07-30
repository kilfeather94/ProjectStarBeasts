using UnityEngine;
using System.Collections;

public class SpriteShoot : MonoBehaviour {

    Animator anim;

    public Animator HolderAnim;

    private float h;
    private float v;

   private AudioSource audS;
   public AudioClip gunSound;

    public int weaponNum = 0;

    Vector3 camPos;

    

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        audS = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        RayCasting();

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("fire");
          //  ShootRay();
            audS.PlayOneShot(gunSound, 1);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("drink");
        }

      if(Input.GetKeyDown(KeyCode.Q))
        {
           
                weaponNum++;
                anim.SetInteger("Weapon_ID", weaponNum);
            if(weaponNum > 2)
            {
                weaponNum = 0;
                anim.SetInteger("Weapon_ID", weaponNum);
            }
        }
      

        // anim.SetFloat("Vertical", v);
        //  anim.SetFloat("Horizontal", h);

        if (h > 0.1f || h < 0f || v > 0.1f || v < 0f)
        {
            //   anim.SetBool("Moving", true);
            HolderAnim.SetBool("Moving", true);
        }
        else if(h == 0f && v == 0f)
        {
            //  anim.SetBool("Moving", false);
            HolderAnim.SetBool("Moving", false);
        }
	}

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

  private void RayCasting()
    {
        // Vector3 fwd = transform.TransformDirection(Vector3.forward);

    //    camPos = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.3f, Camera.main.transform.position.z);

        Vector3 fwd = Camera.main.transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(Camera.main.transform.position, fwd * 9000, Color.green);

        if(Input.GetMouseButtonDown(0) && Physics.Raycast(Camera.main.transform.position, fwd, out hit, 9000))
        {

            if(hit.transform.GetComponent<EnemyAI>())
            {
                hit.transform.GetComponent<EnemyAI>().health--;
            }
        }
       
    }


    /*
    public void ShootRay()
    {
      //  if(Time.time > NextShot)
      //  {
            float x = Screen.width / 2;
            float y = Screen.height / 2;

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y, 0));
            RaycastHit hit;

        Vector3 startPos = this.transform.position; //this.transform.TransformPoint(Vector3.zero);
            Vector3 endPos = Vector3.zero;

            Debug.DrawRay(startPos, endPos, Color.green);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
               // float distance = Vector3.Distance(this.transform.position, hit.point); // distance from bullet spawn point to hit point

              //  RaycastHit[] hits = Physics.RaycastAll(startPos, hit.point - startPos, distance);

            
                foreach (RaycastHit hit2 in hits)
                {
                    if (hit2.transform.GetComponent<CapsuleCollider>()) // if hits rigidbody
                    {
                        Debug.Log("Hit Object");
                    }
                    // else
                    //  {

                    //  }
                }
                

                if(hit.transform.GetComponent<CapsuleCollider>())
                {
                    Debug.Log("Hit Object");
                }

                endPos = hit.point;
            }
            else
            {
                endPos = ray.GetPoint(100);
            }

      //  }
    }
    */
}
