using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float movementSpeed = 10f;
    public Camera camera;

    public GameObject endScreen;

    Rigidbody2D rb;

    float movement = 0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        // if (Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);
        //     Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);

        //     if (touch_Pos.x > 0)
        //     {
        //         movement = -1 * movementSpeed;
        //     }
        //     else if (touch_Pos.x < 0)
        //     {
        //         movement = 1 * movementSpeed;
        //     }
        // }

        // if (Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

        //     if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
        //     {
        //         // get the touch position from the screen touch to world point
        //         Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
        //         // lerp and set the position of the current object to that of the touch, but smoothly over time.
        //         transform.position = Vector3.Lerp(transform.position * 5, touchedPos * 5, Time.deltaTime * 5);
        //     }
        // }


        ///TODO
        if (transform.position.y < camera.transform.position.y - 6 && MainMenu.gameMode == 1)
        {
            endScreen.SetActive(true);
            Debug.Log("Game Over");
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate()
    {

        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "coin")
        {
            Score.score += 1;
            Destroy(col.gameObject);
        }

        if (col.tag == "point")
        {
            Score.score += 1;
            Destroy(col.gameObject);
        }

        if (col.tag == "dead")
        {
            endScreen.SetActive(true);
            Debug.Log("Game Over");
        }

    }
}
