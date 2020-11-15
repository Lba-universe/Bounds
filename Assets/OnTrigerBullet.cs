using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigerBullet : MonoBehaviour
{

    [SerializeField] 
    string TriggerTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TriggerTag && enabled)
        {


            Destroy(this.gameObject);


        }
    }
}
