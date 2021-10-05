using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars_2 : MonoBehaviour
{
    [Range(0f, 10f)]
    public float velocidad = 5f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.down * velocidad;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colision)
    {

        if (colision.gameObject.tag == "Destructor1")
        {
            Destroy(gameObject);
        }

        if (colision.gameObject.tag == "destruir")
        {
            Destroy(gameObject);
        }

        if (colision.gameObject.tag == "siga")
        {
            rigidbody2D.velocity = Vector2.down * velocidad;
        }

        if (colision.gameObject.tag == "parar1")
        {
            rigidbody2D.velocity = Vector2.down * 0;
        }

    }
}
