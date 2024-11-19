using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMovement : MonoBehaviour
{
    // Speed of Movement
    float moveSpeed = 1.0f;
    // Height of Oscillation
    float amplitude = 1.0f;
    // Stores Initial Position
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        // Stores Initial Position
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * amplitude;

        Vector3 newPosition = startPos + Vector3.up * verticalMovement;
        transform.position = newPosition;
    }
}
