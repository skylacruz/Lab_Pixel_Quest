using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;
public class GEOCONTROLLER : MonoBehaviour
{
    int var1 = 3;
    string Var2 = "Hello";
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        Var2 = "Goodbye";
        Debug.Log(Var2 + "World");
    }

    // Update is called once per frame
    void Update()
    {
        //Rb.velocity = new Vector2(-1, Rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Rb.velocity = new Vector2(-1, Rb.velocity.y);
        }
        //Rb.velocity = new Vector2(-1, Rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.D))
        {
            Rb.velocity = new Vector2(-1, Rb.velocity.y);


        }
    }
}     /*
        Debug.Log(var1);
        var1++;

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(+1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 1);
        }
    }
}
        */
