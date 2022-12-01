using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // Lets an object move forward with a speed of 40 every second
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
