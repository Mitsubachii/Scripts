using UnityEngine;

public struct PlayerStatus
{
    public float currentHealth;
    public float maxHealth;
    public float currentMana;
    public float maxMana;
    public double currentExp;
    public double maxExp;
    public float speed;
    public float damageMin;
    public float damageMax;
    public float critChance;
    public float critMulti;
    public string damageType;
    public int level;
    public int maxLevel;

    public PlayerStatus(
        float currentHealth, float maxHealth, float currentMana, float maxMana, double currentExp, double maxExp,
        float damageMin, float damageMax, float critChance, float critMulti, string damageType, int level, int maxLevel = 50, float speed = 5f)
        {
            this.currentHealth = currentHealth;
            this.maxHealth = maxHealth;
            this.currentMana = currentMana;
            this.maxMana = maxMana;
            this.currentExp = currentExp;
            this.maxExp = maxExp;
            this.speed = speed;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
            this.critChance = critChance;
            this.critMulti = critMulti;
            this.damageType = damageType;
            this.level = level;
            this.maxLevel = maxLevel;
        }

    public float danoFinal() => Utilitarios.CalcDmgTotal(damageMin, damageMax, critChance, critMulti); 
}
