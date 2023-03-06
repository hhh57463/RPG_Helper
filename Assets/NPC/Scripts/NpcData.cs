using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NPC Data", menuName = "Scriptable Object/NPC Data", order = int.MaxValue)]
public class NpcData : ScriptableObject
{
    public string npcName;
    public Sprite npcSprite;
}
