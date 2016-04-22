using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfigScript : MonoBehaviour {

    public Text info;
    public GameObject settings;
    public Text title;

    // Use this for initialization
    void Start () {
	
	}
	public void Settings()
    {
        info.gameObject.SetActive(false);
        settings.SetActive(true);
    }
    public void changeText(Text choosen)
    {
        settings.SetActive(false);
        info.gameObject.SetActive(true);
        info.text = choosen.text;
    }
    public void changeTitle(string newTitle)
    {
        title.text = newTitle;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
