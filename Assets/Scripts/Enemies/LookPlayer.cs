using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform thePlayer; // A játékos deklarációja, transform osztálytípusként
    public Vector3 targetOffset;
    public bool enableVerticalTurn = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = thePlayer.position + targetOffset;
        Vector3 selfPoint = transform.position;
        Vector3 dir = targetPoint - selfPoint;
        if (dir == Vector3.zero)
        {
            return;
        }
        if (!enableVerticalTurn)
        {
            float verticalAngle = transform.eulerAngles.x;
            dir.y = 0;
            if (dir == Vector3.zero)
            {
                return;
            }
            Vector3 euler = Quaternion.LookRotation(dir).eulerAngles;
            euler.x = verticalAngle;
            transform.rotation = Quaternion.LookRotation(euler);
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
        //transform.LookAt(thePlayer); // célpontra nézés
    }
}
