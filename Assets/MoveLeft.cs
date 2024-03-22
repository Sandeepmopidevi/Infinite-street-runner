using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 14.0f;
    private PlayerController playerControllerScript;
    private float leftBound = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject); 
        }
    }
}