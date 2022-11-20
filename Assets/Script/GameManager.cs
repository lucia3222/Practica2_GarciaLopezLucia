using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Image live;
    public float liveNow;
    public float liveMax;
    public GameObject enemy;


   

    public int points = 0;

    void Start()
    {

        points = GetPunt();
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }



    }
    void Update()
    {
        live.fillAmount = liveNow / liveMax;
    }

    public int GetPunt()
    {
        return points;
    }

}
