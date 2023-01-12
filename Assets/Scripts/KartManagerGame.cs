using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartManagerGame : MonoBehaviour
{
    public int m_id = 0;
    public GameObject[] kartList;
    // Start is called before the first frame update
    void Start()
    {
        m_id = PlayerPrefs.GetInt("kartId");
        for (int i = 0; i < kartList.Length; i++)
            kartList[i].SetActive(false);
        kartList[m_id].SetActive(true);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
