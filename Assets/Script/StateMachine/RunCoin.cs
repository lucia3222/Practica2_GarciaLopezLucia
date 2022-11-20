using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCoin : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float speed = 2f;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Target").transform;
        }
    }

    void Update()
    {
        int direction = -1;
        transform.position = Vector3.MoveTowards(transform.position, player.position, (speed * direction) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        gameManager.liveNow++;
        
    }
}
