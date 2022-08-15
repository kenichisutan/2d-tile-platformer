using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followSubject;
    void Update()
    {
        transform.position = followSubject.transform.position + new Vector3(0, 0, -10);
    }
}
