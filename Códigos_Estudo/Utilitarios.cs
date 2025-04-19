using UnityEngine;

public static class Utilitarios
{
    public static bool Critical(float CritChance) => Random.value < CritChance;

    public static float CalcDmgBase(float DamageMin, float DamageMax) => Random.Range(DamageMin, DamageMax);

    public static float CalcDmgTotal(float DamageMin, float DamageMax, float CritChance, float CritMulti)
    {
        float danoBase = CalcDmgBase(DamageMin, DamageMax);
        return Critical(CritChance) ? danoBase * CritMulti : danoBase;
    }

    public static double GainExp(double CurrentExp, double expOnDeath) => CurrentExp + expOnDeath;

    public static bool Level_Up(double CurrentExp, double MaxExp, int level, int MaxLevel) => level <= MaxLevel && CurrentExp >= MaxExp;

    public static float HealthControl(float CurrentHealth, float MaxHealth) => Mathf.Clamp(CurrentHealth, 0, MaxHealth);

    public static float ManaControl(float CurrentMana, float MaxMana) => Mathf.Clamp(CurrentMana, 0, MaxMana);

}
