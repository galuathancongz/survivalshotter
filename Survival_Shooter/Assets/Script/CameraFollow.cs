using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public Transform Player;
     Vector3 camfollow;
    // Start is called before the first frame update
    void Start()
    {
     
        camfollow = Player.position- transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = Player.position- Player.rotation*camfollow;
        transform.LookAt(Player);
        transform.rotation= Quaternion.EulerAngles(0, transform.rotation.y, 0);
   
    }
}
