using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {


    public float key;
    public bool Happy;
   
	// Use this for initialization
	void Start () {
   
	
	}
	
	// Update is called once per frame
	void Update () {
   
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (other.GetComponent<MoveBall>().key == key)
            {
                Happy = true;
                
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (other.GetComponent<MoveBall>().key == key)
            {
                Happy = false;
                
            }
        }

    }

}
