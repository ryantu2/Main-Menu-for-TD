using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public AudioMixer mixer;

    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;
    List<string> resolutionList = new List<string>();
    int currentResolutionIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string s = resolutions[i].width + "x" + resolutions[i].height;
            resolutionList.Add(s);

            //check the curent resolution of our LIST OF RESOLUTIONS and see if it is the same as the system(?) resolution
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                //if same remember that shit!!!
                currentResolutionIndex = i;
                //Debug.Log(i);
            }
        }

        resolutionDropdown.AddOptions(resolutionList);
        //now set the default value of our dropdow
        resolutionDropdown.value = currentResolutionIndex;
        //refresh that shit ...umm not sure why..something something unity something something
        resolutionDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Back()
    {
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        Debug.Log("Clicked back");
    }
    public void SetVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);
    }

    public void ToggleFullScreen(bool full)
    {
        Screen.fullScreen = full;

    }

    public void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void Resolution(int i)
    {
        Screen.SetResolution(resolutions[i].width, resolutions[i].height, Screen.fullScreen);
    }
}
