using UnityEngine;
using System.Collections;

public class Starting : MonoBehaviour {
    public string Langkey = "lang";
    public string SoundKey = "sound";
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
