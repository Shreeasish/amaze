using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseScript : ScriptableObject {

    public GameObject PauseMenu;
    GameObject PauseMenuReference;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {


    }

    


    public void onClickPauseButton()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            Instantiate(PauseMenu).name = "PauseMenu";
        }
    }


    public void onClickResumeButton()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Destroy(GameObject.Find("PauseMenu"));
        }
    }

    public void onClickVolumeButton()
    {
      //Toggle Audio
    }


    public void onClickRestartButton()
    {
        Debug.Log("Restart Button Clicked");
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
