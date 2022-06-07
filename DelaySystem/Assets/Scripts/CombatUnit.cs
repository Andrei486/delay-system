using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUnit : MonoBehaviour
{

    [field: SerializeField] public float Delay { get; set; }
    [field: SerializeField] public float Speed { get; private set; }

    [field: SerializeField] public string UnitName { get; }
    private TurnManager TurnOrder;

    // Start is called before the first frame update
    void Start()
    {
        TurnOrder = TurnManager.GetTurnManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoAction(CombatAction action, Vector3 targetPosition) {
        action.Perform(this, targetPosition);
        Delay += action.SelfDelay;
        TurnOrder.AdvanceTurnOrder();
    }
}
