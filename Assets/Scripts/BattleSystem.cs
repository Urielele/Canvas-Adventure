using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{

    public GameObject enemyPrefab;
    public Transform enemyBattleStation;


    Unit playerUnit;
    Unit enemyUnit;

    public BattleState state;

    

    void Start()
    {
        state = BattleState.START;
        setupBattle();
    }

    void setupBattle() 
    {
        GameObject playerGO = GameObject.Find("Player");
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();
    }


}
