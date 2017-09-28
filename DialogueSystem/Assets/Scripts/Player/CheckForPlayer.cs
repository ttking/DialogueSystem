using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForPlayer : MonoBehaviour {

    public DialogueTrigger diaTrigger;

    public Text startConversationText;

	void Start()
    {
        DialogueTrigger diaTrigger = gameObject.GetComponent<DialogueTrigger>();

        startConversationText.text = "Press [E] to start talking";
        startConversationText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Enable Text
            startConversationText.gameObject.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            diaTrigger.TriggerDialogue();
            startConversationText.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Disable Text
            startConversationText.gameObject.SetActive(false);
        }
    }
}
