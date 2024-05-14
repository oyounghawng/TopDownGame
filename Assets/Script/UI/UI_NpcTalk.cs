using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_NpcTalk : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI InfoText;
    [SerializeField] private TextMeshProUGUI talkScrpit;
    private NpcSO npcso;

    public void SeTinfo(NpcSO npcSO)
    {
        npcso = npcSO;
        InfoText.text = npcso.Name;
    }

    public void SetTalk()
    {
        talkScrpit.text = npcso.talkScript;
    }
}
