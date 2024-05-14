using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ParticipantsFrame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Titletext;

    public void SetInfo(NpcSO npcSO)
    {
        Titletext.text = "";
        Titletext.text = npcSO.Name + " " + npcSO.Description;
    }
    public void SetPlayerInfo()
    {
        Titletext.text = GameManager.Instance.NickName;
    }
}
