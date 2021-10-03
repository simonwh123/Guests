using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text dialogueText;
    public GameObject dialogueImage;
    public bool dialogueActive;
    public bool canContinue;
    public AudioSource sound;


    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        canContinue = false;
        dialogueActive = true;
        dialogueImage.SetActive(true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {


        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        canContinue = false;

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            sound.Play();
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
        canContinue = true;
    }

    public void EndDialogue()
    {
        dialogueActive = false;
        dialogueImage.SetActive(false);
    }
}
