using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class praktikum : MonoBehaviour
{
    public int playerHealth;
    public int playerArmor;
    public int playerDamage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Status Player: " + GetPlayerStatus());
        Debug.Log("Damage Efektif yang Diterima: " + CalculateEffectiveDamage());
        Debug.Log("Apakah Player Masih Hidup? " + IsPlayerAlive());
    }

    public string GetPlayerStatus()
    {
        if (playerHealth > 75)
            return "Sehat";
        else if (playerHealth > 40)
            return "Luka Ringan";
        else if (playerHealth > 0)
            return "Kritis";
        else
            return "Mati";
    }

    public int CalculateEffectiveDamage()
    {
        int effectiveDamage = playerDamage - playerArmor;
        return Mathf.Max(effectiveDamage, 0);
    }

    public bool IsPlayerAlive()
    {
        return playerHealth > 0;
    }

    void Update()
    {
        
    }
}
