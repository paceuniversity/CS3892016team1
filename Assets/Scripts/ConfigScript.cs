using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfigScript : MonoBehaviour {

    public Text info;
    public GameObject settings;
    public Text title;
    public Text sound;
    public Text lang;
    public Text buttonHelp;
    public Text buttonSettings;
    public Text buttonAbout;
    public Slider soundSlider;
    public static string language = "En";
    public static string Langkey = "lang";
    public static string SOUNDKEY = "sound";
    public static string soundOn = "On";
    //ChangeLanguage changeLanguage;

  
    // Use this for initialization
    void Start () {
       

        if (!PlayerPrefs.HasKey(Langkey))
        {
            PlayerPrefs.SetString(Langkey, language);
        }
        if (!PlayerPrefs.HasKey(SOUNDKEY))
        {
            PlayerPrefs.SetString(SOUNDKEY, soundOn);
        }
        setSoundSlider();
        ChangeButtons();
        updateSettings();
    }
	public void Settings()
    {
        info.gameObject.SetActive(false);
        settings.SetActive(true);
        
    }
    public void changeText_En(Text choosen_En)
    {
        //string key = "Lang"//changeLanguage.GetKey();
        settings.SetActive(false);
        info.gameObject.SetActive(true);
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
        {
            info.text = choosen_En.text;
        }
            
    }
    public void changeText_Pt(Text choosen_Pt)
    {
        //string key = changeLanguage.GetKey();
        settings.SetActive(false);
        info.gameObject.SetActive(true);
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
        {
            info.text = choosen_Pt.text;
        }

    }
    public void changeTitle_Pt(Text choosen_Pt)
    {
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
            title.text = choosen_Pt.text;
    }

    public void changeTitle_En(Text choosen_En)
    {
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
            title.text = choosen_En.text;
    }

    public void updateSettings()
    {
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
        {
            lang.text = "Language";
            sound.text = "Sound";
            title.text = "Settings";
        }
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
        {
            lang.text = "idioma";
            sound.text = "som";
            title.text = "Config";
        }
    }

    public void ChangeButtons()
    {
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
        {
            buttonAbout.text = "About";
            buttonHelp.text = "Help";
            buttonSettings.text = "Settings";
        }
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
        {
            buttonAbout.text = "Sobre";
            buttonHelp.text = "Ajuda";
            buttonSettings.text = "Config";
        }
    }
    void setSoundSlider()
    {
        if (PlayerPrefs.GetString(SOUNDKEY).Equals("On"))
        {
            soundSlider.value = 1;
        }
        if (PlayerPrefs.GetString(SOUNDKEY).Equals("Off"))
        {
            soundSlider.value = 0;
        }
    }

    void audioOnOff()
    {
       
        if (PlayerPrefs.GetString(SOUNDKEY).Equals("On"))
        {
            AudioListener.pause = false;
        }
        if (PlayerPrefs.GetString(SOUNDKEY).Equals("Off"))
        {
            AudioListener.pause = true;
        }

    }

    void soundOnOff ()
    {
        
        if (soundSlider.value == 0 && !soundOn.Equals("Off"))
        {
            soundOn = "Off";
            PlayerPrefs.SetString(SOUNDKEY, soundOn);
            
        }
        else if (soundSlider.value == 1 && !soundOn.Equals("On"))
        {
            soundOn = "On";
            PlayerPrefs.SetString(SOUNDKEY, soundOn);
            
        }

    }
    // Update is called once per frame
    void Update () {
        soundOnOff();
        audioOnOff();
    }
}
