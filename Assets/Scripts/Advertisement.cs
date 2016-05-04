using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Advertisement : MonoBehaviour {
    public string Langkey = "lang";
    public Text show;
    public Text Add1;
    public Text Add2;
    public Text Add3;
    public Text Add1_Pt;
    public Text Add2_Pt;
    public Text Add3_Pt;
    public Text next;
    private float random;
    // Use this for initialization
    void Start () {
        random = Random.value;
        
            if (PlayerPrefs.GetString(Langkey).Equals("En"))
            {
            next.text = "continue";
            if (random < 0.33f)
            {
                show.text = Add1.text;
            }

            if (random >= 0.33f && random < 0.66f)
            {
                show.text = Add2.text;
            }
            if (random >= 0.66f)
            {
                show.text = Add3.text;
            }
        }
            if (PlayerPrefs.GetString(Langkey).Equals("Pt"))
            {
            next.text = "continuar";
            if (random < 0.33f)
            {
                show.text = Add1_Pt.text;
            }

            if (random >= 0.33f && random < 0.66f)
            {
                show.text = Add2_Pt.text;
            }
            if (random >= 0.66f)
            {
                show.text = Add3_Pt.text;
            }
        }
        
        
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
