using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public GameObject[] gameObject = new GameObject[6];

    public bool oilFlag = false;

    public GameObject[] speedGO = new GameObject[2];

    public GameObject KartGloabal;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimerRoutine", 0.1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //speed
        Text txt = speedGO[0].GetComponent<Text>();
        float speed = this.GetComponent<KartGame.KartSystems.ArcadeKart>().current_speed_recup;

        if (speed <= 2.5)
            speed = 0;

        txt.text = speed.ToString();

        //needle
        float angle = (speed * 210) / 15;
        angle += 180;
        speedGO[1].transform.eulerAngles = new Vector3(speedGO[1].transform.eulerAngles.x, speedGO[1].transform.eulerAngles.y, -angle);
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
