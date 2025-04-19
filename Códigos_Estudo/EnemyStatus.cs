using UnityEngine;
using System;

public class EnemyStatus
{
    private float _currentHealth;
    private float _maxHealth;
    private float _damageMin;
    private float _damageMax;
    private double _expOnDeath;
    private float _critChance;
    private float _critMulti;
    private string _damageType;
    private float _speed;

    public float CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = Mathf.Clamp(value, 0, _maxHealth);
    }

    public float MaxHealth
    {
        get => _maxHealth;
        set => _maxHealth = Mathf.Max(1, value);
    }
    public double ExpOnDeath
    {
        get => _expOnDeath;
        set => _expOnDeath = Math.Max(1, value);
    }

    public float Speed
    {
        get => _speed;
        set => _speed = Mathf.Max(0, value);
    }

    public float DamageMin
    {
        get => _damageMin;
        set => _damageMin = Mathf.Max(1, value);
    }

    public float DamageMax
    {
        get => _damageMax;
        set => _damageMax = Mathf.Max(1, value);
    }

    public float CritChance
    {
        get => _critChance;
        set => _critChance = Mathf.Clamp(value, 0, 1f);
    }

    public float CritMulti
    {
        get => _critMulti;
        set => _critMulti = Mathf.Max(1f, value);
    }

    public string DamageType
    {
        get => _damageType;
        set => _damageType = string.IsNullOrEmpty(value) ? "Fisico" : value;
    }


    public EnemyStatus(float currentHealth, float maxHealth, float damageMin, float damageMax, double expOnDeath, float critChance, float critMulti, string damageType, float speed = 5f)
    {
        _currentHealth = currentHealth;
        _maxHealth = maxHealth;
        _damageMin = damageMin;
        _damageMax = damageMax;
        _expOnDeath = expOnDeath;
        _critChance = critChance;
        _critMulti = critMulti;
        _damageType = damageType;
        _speed = speed;
    }
    public float DanoFinal() => Utilitarios.CalcDmgTotal(DamageMin, DamageMax, CritChance, CritMulti);
}
