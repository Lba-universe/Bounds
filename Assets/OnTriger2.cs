using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriger2 : MonoBehaviour
{
    [SerializeField] 
    string TriggerTagRight;
    [SerializeField]
    string TriggerTagLeft;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TriggerTagRight )
        {
            Camera camera = Camera.main;
            float halfHeight = camera.orthographicSize;
            float halfWidth = camera.aspect * halfHeight;

            float horizontalMin = -halfWidth;
            float horizontalMax = halfWidth;
            
            float y = this.gameObject.transform.position.y;
            this.gameObject.transform.position=new Vector2(horizontalMin,y);

        }
        if (collision.tag == TriggerTagLeft)
        {
            Camera camera = Camera.main;
            float halfHeight = camera.orthographicSize;
            float halfWidth = camera.aspect * halfHeight;

            float horizontalMin = -halfWidth;
            float horizontalMax = halfWidth;

            float y = this.gameObject.transform.position.y;
            this.gameObject.transform.position = new Vector2(horizontalMax, y);

        }

    }
}
