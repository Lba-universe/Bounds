using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLaser : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] float speed = 100f;

    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * speed, 0);
    }


   
}
