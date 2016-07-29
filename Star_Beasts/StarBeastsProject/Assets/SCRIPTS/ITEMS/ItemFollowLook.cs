using UnityEngine;
using System.Collections;

public class ItemFollowLook : MonoBehaviour
{

   private GameObject target;
   public float smoothSpeed;

	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	

	void Update ()
    {
        Vector3 targetPos = target.transform.position;
        targetPos.y = transform.position.y;
        Quaternion targetDir = Quaternion.LookRotation(targetPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetDir, smoothSpeed * Time.deltaTime);
	}
}
