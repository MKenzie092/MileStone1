using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpin : MonoBehaviour
{
    public float rotationSpeed = 50f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}
