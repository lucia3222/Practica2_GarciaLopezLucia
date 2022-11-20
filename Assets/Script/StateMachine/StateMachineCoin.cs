using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineCoin : MonoBehaviour
{
    //2 estados , patrullar y perseguir.
    public MonoBehaviour Idle;
    public MonoBehaviour Run;

    private MonoBehaviour ActualState; //estado que se esta realizando en el momento

    void Start()
    {
        ActiveState(Idle);//activer estados
    }
    public void ActiveState(MonoBehaviour newState)
    {
        if (ActualState != null)
        {
            ActualState.enabled = false;
        }
        ActualState = newState;
        ActualState.enabled = true;
    }
}