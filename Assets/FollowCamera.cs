using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this camera position should be the same as the car postion

    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10); 
    }
}
