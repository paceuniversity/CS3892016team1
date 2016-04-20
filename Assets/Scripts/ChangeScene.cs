using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {


    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

   
}
