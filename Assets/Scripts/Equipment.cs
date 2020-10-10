using System;
using UnityEngine;

public enum Rarity { Common, Rare, Epic, Legendary }
public enum Slot { Arm, Head, Leg, Back }

[Serializable]
public class Equipment
{
    public string name;
    public int value = 1;
    public Rarity rarity;
    public Slot slot;
}
