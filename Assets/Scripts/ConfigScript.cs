using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfigScript : MonoBehaviour {

    public Text info;
    public GameObject settings;
    public Text title;
    public Text sound;
    public Text lang;
    public string language = "En";
    public string Langkey = "lang";
    //ChangeLanguage changeLanguage;

    // Use this for initialization
    void Start () {
        if (!PlayerPrefs.HasKey(Langkey))
        {
            PlayerPrefs.SetString(Langkey, language);
        }
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

    void updateSettings()
    {
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
        {
            lang.text = "Language";
            sound.text = "Sound";
        }
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
        {
            lang.text = "idioma";
            sound.text = "som";
        }
    }
    // Update is called once per frame
    void Update () {
        updateSettings();
    }
}
