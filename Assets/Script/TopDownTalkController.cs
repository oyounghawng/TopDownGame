using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownTalkController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "NPC")
        {
            GameManager.Instance.uiManager.UI_NpcTalk.SetActive(true);
            NpcSO so = collision.GetComponent<NpcController>().NpcSO;
            GameManager.Instance.uiManager.UI_NpcTalk.GetComponent<UI_NpcTalk>().SeTinfo(so);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "NPC")
        {
            GameManager.Instance.uiManager.UI_NpcTalk.SetActive(false);
        }
    }
}
