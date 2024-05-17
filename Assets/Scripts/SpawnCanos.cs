using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCanos : MonoBehaviour
{
    public GameObject Canos;
    public float tempoMax = 1f, tempo = 0f;
    public float alturamin = -0.5f, alturamax = 3.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > tempoMax)
        {
            GameObject novoCano = Instantiate(Canos);
            novoCano.transform.position = transform.position + new Vector3(0, Random.Range(alturamin, alturamax), 0);
            Destroy(novoCano, 20f);
            tempo = 0;
        }

        tempo += Time.deltaTime;
    }
}
