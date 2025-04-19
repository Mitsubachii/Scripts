using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerStatus ps;

    void Start()
    {
        ps = new PlayerStatus(100f, 100f, 50f, 50f, 0f, 50f, 1f, 3f, 0.2f, 2f, "Fisico", 1);
    }


    private void aumentarLevel()
    {
        if(Utilitarios.Level_Up(ps.currentExp, ps.maxExp, ps.level, ps.maxLevel))
        {
            ps.level ++;
            ps.maxHealth += 5;
            ps.maxMana += 2;
            ps.damageMin += 1;
            ps.damageMax += 1;
        }
    }

    private void CalcularDano()
    {
        ps.critChance = 0.2f;
        ps.critMulti = 2f;
        ps.danoFinal();
    }

    private void Die() => ps.currentHealth = 0;

    private void AtualizarVida() => ps.currentHealth = Utilitarios.HealthControl(ps.currentHealth, ps.maxHealth);
    private void AtualizarMana() => ps.currentMana = Utilitarios.ManaControl(ps.currentMana, ps.maxMana);
    
}
