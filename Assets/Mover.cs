using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 11f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }
}
