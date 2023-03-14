using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    [field: SerializeField] public Race Race { get; protected set; }
    [field: SerializeField] public string Description { get; protected set; }
    public virtual void Intrinsic() { }
}

public class Human : Character
{
    public Human()
    {
        Race = Race.Human;
        Description = "Human";
    }

    public override void Intrinsic()
    {

    }
}

public class Dragon : Character
{
    public Dragon()
    {
        Race = Race.Dragon;
        Description = "Dragon";
    }

    public override void Intrinsic()
    {

    }
}

public class Demon : Character
{
    public Demon()
    {
        Race = Race.Demon;
        Description = "Demon";
    }

    public override void Intrinsic()
    {

    }
}

public class Ghost : Character
{
    public Ghost()
    {
        Race = Race.Ghost;
        Description = "Ghost";
    }

    public override void Intrinsic()
    {

    }
}

public enum Race
{
    Human,
    Dragon,
    Demon,
    Ghost
}
