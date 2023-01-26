using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndMoveBoneScript : MonoBehaviour
{
    float RotationSpeed;
    float FloatingHeight;
    //float Rotation;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
        RotationSpeed = Random.Range(180, 360);
        //FloatingHeight = Random.Range(0, 1);
        FloatingHeight = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, RotationSpeed * Time.deltaTime));
        FloatingHeight += 5f * Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Sin(FloatingHeight) * 0.3f * Time.deltaTime, 0);
    }
}
