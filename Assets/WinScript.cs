using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

    GoalScript OtherGoalScript;
    bool happy;
    public GameObject GameWinCanvas;
	// Use this for initialization
	void Start () {
        OtherGoalScript = GameObject.FindGameObjectWithTag("GreenGoal").GetComponent<GoalScript>();
	}
	
	// Update is called once per frame
	void Update () {

        if (OtherGoalScript.Happy)
        {
            if (GetComponent<GoalScript>().Happy)
            {
                Time.timeScale = 0;
               

                try
                {
                    Instantiate(GameWinCanvas);
                    GameObject.FindGameObjectWithTag("Timer").gameObject.SendMessage("Victory");
                    foreach (var i in GameObject.FindGameObjectsWithTag("Ball"))
                    {
                        i.gameObject.SendMessage("Victory");
                    }
                    
                }
                catch (System.NullReferenceException E)
                {
                    print("Victory Call2");
                }
                finally
                {
                    gameObject.GetComponent<WinScript>().enabled = false;
                }
            }
        }
	
	}
}
