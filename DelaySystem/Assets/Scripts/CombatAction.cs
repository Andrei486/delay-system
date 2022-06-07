using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatAction
{
    public const float MovTargetRange = -1.0f;
    public float TargetRange { get; private set; }
    public float SelfDelay { get; private set; }
    public bool MoveToTarget { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perform(CombatUnit user, Vector3 targetPosition) {
        if (MoveToTarget) {
            user.transform.position = targetPosition;
        }
    }
}
