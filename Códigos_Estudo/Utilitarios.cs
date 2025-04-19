using UnityEngine;

public static class Utilitarios
{
    public static bool Critical(float critChance) => Random.value < critChance;

    public static float CalcDmgBase(float damageMin, float damageMax) => Random.Range(damageMin, damageMax);

    public static float CalcDmgTotal(float damageMin, float damageMax, float critChance, float critMulti)
    {
        float danoBase = CalcDmgBase(damageMin, damageMax);

        if (Critical(critChance))
        {
            return danoBase * critMulti;
        }
        else
        {
            return danoBase;
        }
    }

    public static double GainExp(double currentExp, double expOnDeath) => currentExp + expOnDeath;

    public static bool Level_Up(double currentExp, double maxExp, int level, int maxLevel) => level <= maxLevel && currentExp >= maxExp;

    public static float HealthControl(float currentHealth, float maxHealth) => Mathf.Clamp(currentHealth, 0, maxHealth);

    public static float ManaControl(float currentMana, float maxMana) => Mathf.Clamp(currentMana, 0, maxMana);

}
