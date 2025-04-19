using UnityEngine;
using System;

public struct PlayerStatus
{
    private float _currentHealth;
    private float _maxHealth;
    private float _currentMana;
    private float _maxMana;
    private double _currentExp;
    private double _maxExp;
    private float _speed;
    private float _damageMin;
    private float _damageMax;
    private float _critChance;
    private float _critMulti;
    private string _damageType;
    private int _level;
    private int _maxLevel;

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

    public float CurrentMana
    {
        get => _currentMana;
        set => _currentMana = Mathf.Clamp(value, 0, _maxMana);
    }

    public float MaxMana
    {
        get => _maxMana;
        set => _maxMana = Mathf.Max(1, value);
    }

    public double CurrentExp
    {
        get => _currentExp;
        set => _currentExp = Mathf.Clamp((float)value, 0f, (float)_maxExp);
    }

    public double MaxExp
    {
        get => _maxExp;
        set => _maxExp = Math.Max(1, value);
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
        set => _damageType = string.IsNullOrEmpty(value) ? "Fisico" : DamageType;
    }

    public int Level
    {
        get => _level;
        set => _level = Mathf.Clamp(value, 1, MaxLevel);
    }

    public int MaxLevel
    {
        get => _maxLevel;
        set => _maxLevel = Mathf.Max(1, value);
    }

    public PlayerStatus(float currentHealth, float maxHealth, float currentMana, float maxMana, double currentExp, double maxExp, float damageMin, float damageMax, float critChance, float critMulti, string damageType, int level, int maxLevel = 50, float speed = 5f)
    {
        _maxHealth = Mathf.Max(1, maxHealth);
        _currentHealth = Mathf.Clamp(currentHealth, 0, _maxHealth);

        _maxMana = Mathf.Max(1, maxMana);
        _currentMana = Mathf.Clamp(currentMana, 0, _maxMana);

        _maxExp = Math.Max(1, maxExp);
        _currentExp = Mathf.Clamp((float)currentExp, 0f, (float)_maxExp);

        _damageMin = Mathf.Max(1, damageMin);
        _damageMax = Mathf.Max(1, damageMax);

        _critChance = Mathf.Clamp(critChance, 0, 1f);
        _critMulti = Mathf.Max(1f, critMulti);

        _damageType = string.IsNullOrEmpty(damageType) ? "Fisico" : damageType;

        _maxLevel = Mathf.Max(1, maxLevel);
        _level = Mathf.Clamp(level, 1, _maxLevel);

        _speed = Mathf.Max(0f, speed);
    }
    public float DanoFinal() => Utilitarios.CalcDmgTotal(DamageMin, DamageMax, CritChance, CritMulti); 
}