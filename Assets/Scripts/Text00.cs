using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Text00 : MonoBehaviour
{
    public Text textCom;
    public Image imageCom;
    public string[] texts;
    public Sprite[] images;
    public int curIndex = 0;
    public bool isPlaying = false;

    private Coroutine displayCoroutine;
    void Start()
    {
        TextImage();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isPlaying)
            {
                StopAllCoroutines();
                textCom.text = texts[curIndex];
                isPlaying = false;
            }
            else
            {
                if (textCom.text == texts[curIndex])
                {
                    curIndex++;
                    if (curIndex < texts.Length)
                    {
                        TextImage();
                    }
                }
            }
        }
    }
    void TextImage()
    {
        StartCoroutine(AnimateText(texts[curIndex]));
        imageCom.sprite = images[curIndex];
    }
    IEnumerator AnimateText(string text)
    {
        isPlaying = true;
        textCom.text = "";
        foreach(char c in text)
        {
            textCom.text += c;
            yield return new WaitForSeconds(0.05f);
        }
        isPlaying = false;
    }
}
