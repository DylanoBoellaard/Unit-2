using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players' view in the game, remove that object
        if (transform.position.z > topBound) // Destroys any object (food) on the top of the screen
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) // Destroys any object (animal) on the bottom of the screen
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
