using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerBase
{
    [field: SerializeField] public int Hp { get; set; }
    [field: SerializeField] public int Mp { get; set; }
    [field: SerializeField] public int RecoveryHp { get; set; }
    [field: SerializeField] public int RecoveryMp { get; set; }
    [field: SerializeField] public int PhysicDef { get; set; }
    [field: SerializeField] public int MagicDef { get; set; }
    [field: SerializeField] public int HandForce { get; set; }
    [field: SerializeField] public int SpiritForce { get; set; }
    [field: SerializeField] public float SpeedAttack { get; set; } //percent
    [field: SerializeField] public float SpeedChanting { get; set; } //percent
    [field: SerializeField] public float MoveSpeed { get; set; }

    public PlayerBase(int hp, int mp, int recoveryHp, int recoveryMp, int physicDef, int magicDef, int handForce, int spiritForce, float speedAttack, float speedChanting, float moveSpeed)
    {
        Hp = hp;
        Mp = mp;
        RecoveryHp = recoveryHp;
        RecoveryMp = recoveryMp;
        PhysicDef = physicDef;
        MagicDef = magicDef;
        HandForce = handForce;
        SpiritForce = spiritForce;
        SpeedAttack = speedAttack;
        SpeedChanting = speedChanting;
        MoveSpeed = moveSpeed;
    }

    public PlayerBase()
    {
        Hp = 50;
        Mp = 10;
        RecoveryHp = 1;
        RecoveryHp = 0;
        PhysicDef = 5;
        MagicDef = 5;
        HandForce = 20;
        SpiritForce = 15;
        SpeedAttack = 0;
        SpeedChanting = 0;
        MoveSpeed = 3;
    }
}
