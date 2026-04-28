using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    [Header("Information")]
    public string unitName;

    [Header("Stats")]
    public int unitLevel;
    [HideInInspector] public int healthPoint;
    [HideInInspector] public int manaPoint;
    public int maxHealthPoint;
    public int maxManaPoint;

    [Header("Attributes")]
    public int strength;
    public int magic;
    public int defense;
    public int agility;

    

    private void Awake()
    {
        healthPoint = maxHealthPoint;
        manaPoint = maxManaPoint;
    }

}
