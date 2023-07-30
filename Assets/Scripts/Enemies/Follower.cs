using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float bigRange = 15;
    public float smallRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        float distance = Vector3.Distance(selfPoint, targetPoint);
        if (distance <= bigRange)
        {
            float t = Mathf.InverseLerp(bigRange, smallRange, distance);
            float actualSpeed = Mathf.Lerp(0, speed, t);
            transform.position = Vector3.MoveTowards(selfPoint, targetPoint, actualSpeed * Time.deltaTime);
        }
    }
}
