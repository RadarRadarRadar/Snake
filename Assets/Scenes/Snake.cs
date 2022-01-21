using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SnakeMove", 0.0f, 0.1f);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            _direction = Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            _direction = Vector2.left;
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            _direction = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            _direction = Vector2.right;
        }
    }

    void SnakeMove()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
    }

    // private void FixedUpdate()
    // {
    //     this.transform.position = new Vector3(
    //         Mathf.Round(this.transform.position.x) + _direction.x,
    //         Mathf.Round(this.transform.position.y) + _direction.y,
    //         0.0f
    //     );
    // }
}
