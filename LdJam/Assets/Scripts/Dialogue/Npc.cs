using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Dialogue dialogue;
    private bool colliding;
    public GameObject interactText;
    public DialogueManager dialogueManager;
    public bool playAnim;
    public Animation anim;



    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void Update()
    {


        if (colliding && dialogueManager.dialogueActive == false && Input.GetKeyDown("e"))
        {
            //GetComponent<SphereCollider>().enabled = false;
            TriggerDialogue();
            interactText.SetActive(false);
        }
        if (dialogueManager.dialogueActive && Input.GetKeyDown("e") && dialogueManager.canContinue == true && dialogueManager.sentences.Count > 0)
        {

            dialogueManager.DisplayNextSentence();
        }
        if (dialogueManager.dialogueActive && Input.GetKeyDown("e") && dialogueManager.canContinue == true && dialogueManager.sentences.Count == 0)
        {
            if (playAnim)
            {
                anim.Play();
            }
            dialogueManager.EndDialogue();
        }


    }

    #region colliding
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            colliding = true;
            interactText.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialogueManager.EndDialogue();
            colliding = false;
            interactText.SetActive(false);
            
        }
    }
    #endregion
}
