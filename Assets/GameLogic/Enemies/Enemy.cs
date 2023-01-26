using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity
{
    public EntityStats _stats = new EntityStats();
    private EntityState _state = EntityState.Inactive;

    public EntityStats Stats { get => _stats; set => _stats = value; }
    public EntityState State { get => _state; set => _state = value; }

    public void Attack(IEntity entity)
    {
        entity.Stats.TakeDamage(_stats.Strength);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(1f * Time.deltaTime, 0);
        if (transform.position.x < -10)
            Destroy(gameObject);
    }
}
