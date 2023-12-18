using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
   public Dialogue dialogue;
   public DialogueManager dialogueManager; // Reference to your DialogueManager script


  /* public void TriggerDialogue()
   {
      FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
   }*/


  private void OnTriggerEnter(Collider other)
  {
      if (other.CompareTag("Player"))
      {
          StartDialogue();
      }
  }

  private void OnTriggerExit(Collider other)
  {
      if (other.CompareTag("Player"))
      {
          EndDialogue();
      }
  }

  void StartDialogue()
  {
      if (dialogueManager != null)
      {
          dialogueManager.StartDialogue(dialogue);
      }
      else
      {
          Debug.LogWarning("DialogueManager reference not set!");
      }
  }

  void EndDialogue()
  {
      if (dialogueManager != null)
      {
          dialogueManager.EndDialogue();
      }
      else
      {
          Debug.LogWarning("DialogueManager reference not set!");
      }
  }
}