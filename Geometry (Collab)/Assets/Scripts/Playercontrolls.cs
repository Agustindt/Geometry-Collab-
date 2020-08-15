using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrolls : MonoBehaviour
{

    private Rigidbody2D rb;
    public float velocidadX = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocidadX, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(velocidadX, 5);
        }
    }
}
