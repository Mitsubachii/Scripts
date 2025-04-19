using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerStatus ps;
    void Start()
    {
        ps = new PlayerStatus(100f, 100f, 50f, 50f, 0f, 50f, 1f, 3f, 0.2f, 2f, "Fisico", 1);
        AtualizarVida();
        AtualizarMana();
    }
    private void AumentarLevel()
    {
        if(Utilitarios.Level_Up(ps.CurrentExp, ps.MaxExp, ps.Level, ps.MaxLevel))
        {
            ps.Level ++;
            ps.MaxHealth += 5;
            ps.MaxMana += 2;
            ps.DamageMin += 1;
            ps.DamageMax += 1;
        }
    }

    private void CalcularDano()
    {
        ps.CritChance = 0.2f;
        ps.CritMulti = 2f;
        ps.DanoFinal();
    }
    private void Die() => ps.CurrentHealth = 0;
    private void AtualizarVida() => ps.CurrentHealth = Utilitarios.HealthControl(ps.CurrentHealth, ps.MaxHealth);
    private void AtualizarMana() => ps.CurrentMana = Utilitarios.ManaControl(ps.CurrentMana, ps.MaxMana);
}