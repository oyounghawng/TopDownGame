using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NpcType
{
    Æ©ÅÍ,
    ÇÐ»ý,
}
[CreateAssetMenu(fileName = "DefaultNpcSO", menuName ="TopDown/Npc/Default") ]
public class NpcSO : ScriptableObject
{
    [Header("Npc Info")]
    public NpcType npcType;
    public string Name;
    public string Description;
    public string talkScript;
}
