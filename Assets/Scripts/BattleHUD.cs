using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI playerHPMP;
    [SerializeField] private TextMeshProUGUI playerSTMA;
    [SerializeField] private TextMeshProUGUI playerDEAG;


    private void Start()
    {
        Unit player = GameObject.Find("Player").GetComponent<Unit>();
        setupHUD(player);
    }

    public void setupHUD(Unit unit)
    {
        playerName.text = unit.name + " Lv." + unit.unitLevel;
        playerHPMP.text = "HP : " + unit.healthPoint + "/" + unit.maxHealthPoint + "\nMP : " + unit.manaPoint + "/" + unit.maxManaPoint;
        playerSTMA.text = "ST : " + unit.strength + "\nMA : " + unit.magic;
        playerDEAG.text = "DE : " + unit.defense + "\nAG : " + unit.agility;
    }

    


}
