using System.Collections;
using UnityEngine;
using TMPro;

public class InformantDialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public int zincDialogue = 1;

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        
    }

    public void NextSentence()
    {
        if (VarStorage.zinc)
        {
            if(index < sentences.Length)
            {
                textDisplay.text = "";
                StartCoroutine(Type());
                index++;
            }
            else
            {
                textDisplay.text = "";
                index = 0;
            }
        }
        else
        {
            if (index < sentences.Length - zincDialogue)
            {
                textDisplay.text = "";
                StartCoroutine(Type());
                index++;
            }
            else
            {
                textDisplay.text = "";
                index = 0;
            }
        }

        
    }
}
