using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager
{
    private static TurnManager turnManager = null;
    private int test = 1;

    private List<CombatUnit> activePlayers;

    private TurnManager() {
        this.ClearTurnOrder();
    }

    public void AddPlayer(CombatUnit player) {
        this.activePlayers.Add(player);
    }

    public void RemovePlayer(CombatUnit player) {
        this.activePlayers.Remove(player);
    }

    public void ClearTurnOrder() {
        this.activePlayers = new List<CombatUnit>();
    }

    public void AdvanceTurnOrder() {
        
    }

    public static TurnManager GetTurnManager() {
        if (TurnManager.turnManager == null) {
            TurnManager.turnManager = new TurnManager();
        }
        return TurnManager.turnManager;
    }
}
