using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Camera mainCam;

    public int AngleNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetAngleIndex();
        Debug.Log(AngleNum);
	}

    int GetAngleIndex()
    {
        var dir = mainCam.transform.position - transform.forward;
        var enemyAngle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;

        if (enemyAngle < 0.0f)
            enemyAngle += 360;

    //    Debug.Log("Angle from the player is: " + enemyAngle);

        if (enemyAngle >= 292.5f && enemyAngle < 337.5f)
            // return 8;
            return AngleNum = 8;
        else if (enemyAngle >= 22.5f && enemyAngle < 67.5f)
            return AngleNum = 2;
        else if (enemyAngle >= 67.5f && enemyAngle < 112.5f)
            return AngleNum = 3;
        else if (enemyAngle >= 112.5f && enemyAngle < 157.5f)
            return AngleNum = 4;
        else if (enemyAngle >= 157.5f && enemyAngle < 202.5f)
            return AngleNum = 5;
        else if (enemyAngle >= 202.5f && enemyAngle < 247.5f)
            return AngleNum = 6;
        else if (enemyAngle >= 247.5f && enemyAngle < 292.5f)
            return AngleNum = 7;
        else if (enemyAngle >= 337.5f || enemyAngle < 22.5f)
            return AngleNum = 1;
        else return AngleNum = 0;
    }
}
