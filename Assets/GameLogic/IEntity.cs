using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityState
{
    Inactive,
    Moving,
    Attacking
}

public struct EntityStats
{
    public int Team { get; set; }
    public float Health { get; set; }
    public float Strength { get; set; }
    public float Range { get; set; }

    public void TakeDamage(float dmg)
    {
        Health -= dmg;
    }
}

public interface IEntity
{
    public EntityStats Stats { get; set; }

    public EntityState State { get; set; }

    public void Attack(IEntity entity);
}
