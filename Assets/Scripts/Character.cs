using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not Assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public void Reset()
    {
        this.name = "Not Assigned";
        this.exp = 0;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero {0} - {1} EXP", name, exp);
    }
}

public struct Weapon
{
    public string name;
    public int damage;
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponInfo()
    {
        Debug.LogFormat("Weapon {0} - {1} Damage", name, damage);   
    }
}