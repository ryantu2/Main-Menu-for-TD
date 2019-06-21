using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //variables
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        optionsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
