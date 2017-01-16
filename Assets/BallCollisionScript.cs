using UnityEngine;
using System.Collections;

public class BallCollisionScript : MonoBehaviour {


    GameObject childGO;
    Camera MainCamera;
    public GameObject GameOverCanvas;
    public bool BallDeadFlag;


    void Victory()
    {
        GetComponent<BallCollisionScript>().enabled = false;
    }

    // Use this for initialization
    void Start () {
        childGO = transform.FindChild("Point light").gameObject;
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {

            if (BallDeadFlag == false)
            {

                try
                {
                    GameObject.FindGameObjectWithTag("Timer").gameObject.SendMessage("GameOver", 10);
                    print("1st call");
                }
                catch (System.NullReferenceException e)
                {
                    print("2nd call");
                }



                childGO.AddComponent<flickerDie>();
                
                Camera.main.GetComponent<GlitchEffect>().enabled = true;
                BallDeadFlag = true;

                //pause input
                GetComponent<MoveBall>().enabled = false;

                //screenfader
                try
                {
                    Instantiate(GameOverCanvas);
                }
                catch (UnassignedReferenceException e)
                {
                    print("Yellow Ball");

                }
            }
            


        }
        else {
            var impulse = collision.impulse;

            if (impulse.magnitude > 15 && BallDeadFlag==false)
            {

                childGO.AddComponent<flicker>();
            }
        }

    }
}
