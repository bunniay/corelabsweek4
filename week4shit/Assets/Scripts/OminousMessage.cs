using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OminousMessage : MonoBehaviour
{
    public TMP_Text messageText;
    public List<string> ominousMessages;
    public string displayedMsg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScaryMessages ()
    {
        //two ways to write this

        //NUMBER 1

        //displayedMsg = ominousMessages[Random.Range(0,ominousMessages.Count)];
        //messageText.text = displayedMsg;

        //NUMBER 2
        messageText.text = ominousMessages[Random.Range(0, ominousMessages.Count)];
    }

    public void NewScene()
    {
        SceneManager.LoadScene(1);
    }
}
