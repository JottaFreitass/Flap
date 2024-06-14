using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(9.61f, -3.94f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -9.62)
        {
            transform.position = new Vector3(9.61f, transform.position.y, transform.position.z);
        } 
    }
}
