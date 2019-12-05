using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public static bool cameraActive = true;
    void Start()
    {
        cameraActive = true;
    }
    void LateUpdate()
    {
        if (cameraActive)
        {
            if (MainMenu.gameMode == 2)
            {
                transform.position = target.position;
                // if (target.position.y > transform.position.y)
                // {
                //     Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
                //     transform.position = newPos;
                // }
            }
            else
            {
                transform.position += new Vector3(0, 1, 0) / 40;
            }
        }
    }


    // void LateUpdate () {
    // 	if (target.position.y > transform.position.y)
    // 	{
    // 		Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
    // 		transform.position = newPos;
    // 	}
    // }

}
