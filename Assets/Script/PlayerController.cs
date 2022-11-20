using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    private CharacterController controller;

    public float playerJump = 2f;
    public float playerSpeed = 4f;
    public float gravityFoce = 5f;
    public GameManager gameManager;

    private void Awake()
    {

        Instance = this;

    }

    void Start()
    {

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        float x = -Input.GetAxis("Horizontal");
        float z = -Input.GetAxis("Vertical");

        Debug.Log("x: " + x + " y: " + z);


        Vector3 movement = transform.right * -x + transform.forward * -z;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (controller.isGrounded)
            {
                movement += transform.up * playerJump;
            }

        }

        movement *= Time.deltaTime * playerSpeed;

        movement += transform.up * gravityFoce * Time.deltaTime;

        controller.Move(movement);
        if (gameManager.liveNow <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
           
        }
    }

}
