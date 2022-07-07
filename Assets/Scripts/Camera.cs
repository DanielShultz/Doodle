using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PlayerTransform;

    void Update()
    {
        if (PlayerTransform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, PlayerTransform.position.y, transform.position.z);
            GetComponent<Score>().NewScore((int)transform.position.y);
        }
    }
}
