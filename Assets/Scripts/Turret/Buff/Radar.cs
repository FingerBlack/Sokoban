using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : BuffTurret
{    
    void Start()
    {   
        base.Init();

        healthPoint = 50.0f;
        isCombinable = true;
        base.CombinableInit();
        buffBulletType = BulletType.Slow;
        
        buffValue=1f;
    }

    void Update()
    {   
        base.GetLocalPosition();

        base.BuffSurrounding();

        // only execute if isCombinable
        if(isCombinable){
            if(combinationTarget){
                float dis = Vector3.Distance(transform.parent.transform.position, combinationTarget.transform.position);
                transform.parent.position = Vector3.MoveTowards(transform.parent.position, combinationTarget.transform.position, combinationSpeed * Time.deltaTime);
            }

            if(transferCode != TransferCode.None){
                base.TryCreateUpgradeTurret();
            }
        }
    }
}
