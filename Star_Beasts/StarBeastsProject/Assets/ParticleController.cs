using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

    ParticleSystem pS;

	// Use this for initialization
	void Start ()
    {
        pS = GetComponent<ParticleSystem>();
        pS.playbackSpeed = 20;
        Invoke("DestroyObj", 4);
    }
	
    void DestroyObj()
    {
        Destroy(this.gameObject);
    }
}
