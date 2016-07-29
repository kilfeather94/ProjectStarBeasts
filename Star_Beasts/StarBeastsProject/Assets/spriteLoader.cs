using UnityEngine;
using System.Collections;

public class spriteLoader : MonoBehaviour {

    SpriteRenderer rend;
    public Sprite sprite1;

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();

        rend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	  if(Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(DisableAnimDelay());
          
        }
	}

    public IEnumerator DisableAnimDelay()
    {
        anim.enabled = false;
        rend.sprite = sprite1;
        yield return new WaitForSeconds(2.0f);
        anim.enabled = true;
    }
}
