using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour {
    public string language = "En";
    public string Langkey = "lang";
    public Text En;
    public Text Pt;
    Font tempFont;
    public string GetKey()
    {
        return Langkey;
    }
    
    public string GetLang()
    {
        if (PlayerPrefs.HasKey(Langkey))
                language = PlayerPrefs.GetString(Langkey);

        return language;
    }


    public void SetLang_Pt()
    {
        
        PlayerPrefs.SetString(Langkey, "Pt");
        tempFont = Pt.font;
        Pt.font = En.font;
        En.font = tempFont;
    }

    public void SetLang_En()
    {
        
        PlayerPrefs.SetString(Langkey, "En");
        tempFont = En.font;
        En.font = Pt.font;
        Pt.font = tempFont;
    }

    // Use this for initialization
    void Start () {
        if (!PlayerPrefs.HasKey(Langkey))
        {
            PlayerPrefs.SetString(Langkey, language);
        }
        else
        {
            if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
            {
                tempFont = Pt.font;
                Pt.font = En.font;
                En.font = tempFont;
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
