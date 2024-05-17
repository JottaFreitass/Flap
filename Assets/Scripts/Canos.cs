using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canos : MonoBehaviour
{
    [Range(1,10)] public int speed;

    void Update()
    {
       transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}
