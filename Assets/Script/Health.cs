using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image live;
    public float liveNow;
    public float liveMax;
    public GameObject enemy;
    
   
    void Update()
    {
        live.fillAmount = liveNow / liveMax;
    }
    void OnTriggerEnter(Collider other)
    {
        liveNow --;
    }

}
