using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rig;
    private int vida = 1;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Voar();
        Morrer();
    }

    void Voar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
            animator.Play("voando");
        }
    }
    

    void Morrer()
    {
        if(vida == 0)
        {
            Debug.Log("Morreu");
            animator.Play("morte");
            StartCoroutine("Morte");
        }
    }

    IEnumerator Morte()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Cano"))
        {
            Debug.Log("Perdeu vida!");
            vida = vida - 1;
        }

        if (colisao.gameObject.CompareTag("Chao"))
        {
            Debug.Log("Perdeu vida!");
            vida = vida - 1;
        }
    }
}
