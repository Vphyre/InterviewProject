using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterMessage : MonoBehaviour
{
    [SerializeField] private GameObject popOutObj;
    [SerializeField] private Text popOutText;
    [SerializeField] private float messageTime;
    [SerializeField] private string[] messages;
    private float timer = 0;
    private bool messageTrigger = false;
    
    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && messageTrigger == false)
        {
            messageTrigger = true;
            popOutObj.SetActive(true);
            popOutText.text = RandomText();
            timer = messageTime;
        }

        timer -= Time.deltaTime;

        if(timer <= 0 && messageTrigger)
        {
            messageTrigger = false;
            popOutObj.SetActive(false);
            popOutText.text = "";
        }

    }
    private string RandomText()
    {
        int sort = Random.Range(0, messages.Length-1);
        return messages[sort];
    }
}
