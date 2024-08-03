using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    private Transform sweepTransform;
    private float rotationSpeed;
    private float radarDistance;

    private void Awake()
    {
        sweepTransform = transform.Find("Sweep");
        rotationSpeed = 150f;
        radarDistance = 100f;
    }

    public static Vector3 GetVectorFromAngle(float angle)
    {
        float angleRad = angle * (Mathf.PI/ 180f);
        return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
    }


//    private void Update()
//    {
//        sweepTransform.eulerAngles -= new Vector3(0, 0, rotationSpeed * Time.deltaTime);

//        RaycastHit raycasthit = Physics.Raycast(transform.position, GetVectorFromAngle (sweepTransform.eulerAngles.z), radarDistance);
//        if (raycasthit.collider != null)
//        {
//            Debug.Log("Ping");
//        }
//    }
}
