using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    //2 estados , patrullar y perseguir.
    public MonoBehaviour Patrol;  
    public MonoBehaviour Chase;
    
    private MonoBehaviour ActualState; //estado que se esta realizando en el momento

    void Start()
    {
        ActiveState(Patrol);//activer estados
    }
    public void ActiveState(MonoBehaviour newState)
    {
        if(ActualState !=null)
        {
            ActualState.enabled = false;
        }
        ActualState = newState;
        ActualState.enabled = true;
    }
}
