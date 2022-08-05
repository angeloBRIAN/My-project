using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonScene()
    {
        SceneManager.LoadScene("SampleScene1");
    }
    public void playScene()
    {
        SceneManager.LoadScene("SampleScene2");
    }
}
