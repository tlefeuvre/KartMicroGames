using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartManager : MonoBehaviour
{
    public int m_id = 0;
    public GameObject[] kartList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < kartList.Length; i++)
            kartList[i].SetActive(false);
        kartList[m_id].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public void NextKart()
    {
        kartList[m_id].SetActive(false);
        m_id = (m_id +1) % kartList.Length; ;
        kartList[m_id].SetActive(true);
    }
    public void BackKart()
    {
        kartList[m_id].SetActive(false);
        m_id = (m_id-1) % kartList.Length;
        if (m_id < 0)
            m_id += kartList.Length;

        kartList[m_id].SetActive(true);
    }
    public void callControls()
    {
        kartList[m_id].SetActive(false);

    }
    public void exitControls()
    {
        kartList[m_id].SetActive(true);

    }
}
