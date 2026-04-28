using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;


public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private float typingSpeed;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private IEnumerator DisplayLine(string dialogue) 
    {
        dialogueText.text = "";
        dialogueBox.SetActive(true);
        foreach (char letter in dialogue.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForSeconds(0.2f);
        dialogueBox.SetActive(false);
    }

    public void PlayDialogue(string dialogue)
    {
        
        StartCoroutine(DisplayLine(dialogue));
        
    }

    public void Start()
    {
        PlayDialogue("Hai semuanya aku bimo sang developer");
        Debug.Log("test");
    }

}
