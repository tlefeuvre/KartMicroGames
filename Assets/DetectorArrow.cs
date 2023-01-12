using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorArrow : MonoBehaviour
{
    public GameObject blueArrow;
    public GameObject greyArrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            blueArrow.SetActive(false);
            greyArrow.SetActive(true);
            Debug.Log("HEY");
        }
    }
}
