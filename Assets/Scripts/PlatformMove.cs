using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public bool LeftRight;
    public float Speed;

    private float AdditionalValueY = 0;
    private float StartedPositionY = 0;

    private void Start()
    {
        if (!LeftRight)
        {
            StartedPositionY = transform.position.y;
        }
    }

    private void FixedUpdate()
    {
        if (LeftRight)
        {
            if (Mathf.Abs(transform.position.x)>2f)
            {
                Speed = -Speed;
            }
            transform.position = new Vector3(transform.position.x + Speed, transform.position.y, transform.position.z);
        }
        else
        {
            if (Mathf.Abs(AdditionalValueY)>1f)
            {
                Speed = -Speed;
            }
            AdditionalValueY += Speed;
            transform.position = new Vector3(transform.position.x, StartedPositionY + AdditionalValueY, transform.position.z);
        }
    }
}
