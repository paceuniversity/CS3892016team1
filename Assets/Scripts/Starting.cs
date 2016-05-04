using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Starting : MonoBehaviour {
    public string Langkey = "lang";
    public string SoundKey = "sound";
    public Text play;
    // Use this for initialization
    void Start () {
        if (!PlayerPrefs.HasKey(Langkey))
        {
            PlayerPrefs.SetString(Langkey, "En");
        }
        if (!PlayerPrefs.HasKey(SoundKey))
        {
            PlayerPrefs.SetString(SoundKey, "On");
        }
        audioOnOff();
        if (PlayerPrefs.GetString(Langkey).Equals("En"))
        {
            play.text = "Play";
        }
        if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
        {
            play.text = "Jogar";
        }

    }
    void audioOnOff()
    {

        if (PlayerPrefs.GetString(SoundKey).Equals("On"))
        {
            AudioListener.pause = false;
        }
        if (PlayerPrefs.GetString(SoundKey).Equals("Off"))
        {
            AudioListener.pause = true;
        }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
