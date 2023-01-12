using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public bool oilFlag = false;

    public GameObject[] gameObject = new GameObject[6];

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimerRoutine", 0.1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimerRoutine()
    {
        gameObject[1].SetActive(!oilFlag);
        gameObject[0].SetActive(oilFlag);

        gameObject[3].SetActive(!oilFlag);
        gameObject[2].SetActive(oilFlag);

        gameObject[5].SetActive(!oilFlag);
        gameObject[4].SetActive(oilFlag);

        oilFlag = !oilFlag;
        
        
    }

}
