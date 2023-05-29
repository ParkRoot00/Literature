using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextSceneName;
    private Text00 text00;
    void Start()
    {
        text00 = FindObjectOfType<Text00>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text00.curIndex >= text00.texts.Length && !string.IsNullOrEmpty(nextSceneName))
            {
                NextScene00();
            }
        }
    }
    void NextScene00()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
