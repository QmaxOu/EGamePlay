﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using EGamePlay.Combat;

namespace EGamePlay.Combat
{
    /// <summary>
    /// 状态能力执行体
    /// </summary>
    public abstract class StatusExecution : Entity, IAbilityExecution
    {
        public CombatEntity InputCombatEntity { get; set; }
        public Vector3 InputPoint { get; set; }
        public float InputDirection { get; set; }
        public Entity AbilityEntity { get; set; }
        public CombatEntity OwnerEntity { get; set; }


        public void BeginExecute()
        {
        }

        public void EndExecute()
        {
        }
    }
}