using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoContoller : MonoBehaviour {
    public int variable1 = 2;
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    SpriteRenderer playerrenderer;
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        playerrenderer = GetComponent<SpriteRenderer>();

        playerrenderer =GetComponentInChildren<SpriteRenderer>();
}

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        xInput *= variable1;
        rb2d.velocity = new Vector2(xInput, rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerrenderer.color = Color.blue;


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerrenderer.color = Color.red;

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerrenderer.color = Color.yellow;


        }

        if (xInput > 0){ playerrenderer.flipX = true;}
        else if (xInput < 0) { playerrenderer.flipX = false;}
    }

    public string nextLevel = "Level2";
    private object _SpriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");

        switch (collision.tag) {
            case "Death": {
                string thisLevel = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(thisLevel);
                break;
            }
            case "Finish": {
                SceneManager.LoadScene(nextLevel);
                break;
            }
    }
    }
}
