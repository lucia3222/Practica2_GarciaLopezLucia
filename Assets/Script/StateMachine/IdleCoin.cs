using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleCoin : MonoBehaviour
{
    public float rotSpeed = 4f;

    
    
    public StateMachineCoin stateMachineC;
    private void Start()
    {
      
    }
    private void Update()
    {
        transform.Rotate(0, rotSpeed, 0, (float)Space.World);
       
    }
    void OnTriggerEnter(Collider other)//ACCION de tocar al jugador.
    {

        stateMachineC.ActiveState(stateMachineC.Run);//cambiar a estado de huida
    }
    
}
