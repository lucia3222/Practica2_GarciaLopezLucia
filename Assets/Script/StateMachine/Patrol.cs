using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{  
    public float enemySpeed = 4f;
    public float changeTargetDist = 0.1f;
    public Transform[] patrolPoints; //lista de puntos de patrulla
    int currentTarget = 0;
   
    public StateMachine stateMachine;
    
    void OnTriggerEnter(Collider other)//ACCION de tocar al jugador.
    {     
        
        stateMachine.ActiveState(stateMachine.Chase);//cambiar a estado de persecución
    }
    
    //movimiento de WayPoint a Waypoint
    void Update()
    {
        if (MoveToTarget())
        {
            currentTarget = GetNextTarget(); 
        }

    }
    
    private bool MoveToTarget() //si ha legado a un target pasa al siguiente.
    {
        Vector3 distanceVector = patrolPoints[currentTarget].position - transform.position;
        if (distanceVector.magnitude < changeTargetDist)
        {
            return true;
        }
        Vector3 velocity = distanceVector.normalized;
        transform.position += velocity * enemySpeed * Time.deltaTime;

        return false;
    }
    //empoeza por el primer elemento de la lista (0) y va sumando 1hasta que llega ala cantidad maxima (Length)
    //despues vuelve a 0 e inicia otra vez el recorrido.
    int GetNextTarget() 
    {
        currentTarget++;
        if(currentTarget >=patrolPoints.Length)
        {
            currentTarget = 0;
        }
        return currentTarget;
    }
}
