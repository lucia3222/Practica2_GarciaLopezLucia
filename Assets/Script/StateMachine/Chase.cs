using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float speed = 2f;       
    public GameManager gameManager;
    public float time = 0f;//crono
    public StateMachine stateMachine;

    void Start()
    {
        time++;
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Target").transform;
        }
        if (time > 3f) //pasados 3 segundos vuelve a su estado de patrulla
        {
            time = 0;
            stateMachine.ActiveState(stateMachine.Patrol);
        }
    }
    void Update()
    {      
        //persecucion
        int direction = 1;
        transform.position = Vector3.MoveTowards(transform.position, player.position, (speed * direction) *  Time.deltaTime);        
    }

    void OnTriggerEnter(Collider other)//ACCION de tocar al jugador.
    {
        gameManager.liveNow--; // restar vida

    }
}
