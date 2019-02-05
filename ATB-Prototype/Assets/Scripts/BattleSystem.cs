using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private GameObject battleMenuPanel;
    [SerializeField] private ATBSystem fighterATB;
    [SerializeField] private ATBSystem swordsmanATB;
    [SerializeField] private ATBSystem mageATB;

    public void InitializeBattle()
    {
        battleMenuPanel.SetActive(true);
    }

    public void PerformAttack(string characterName)
    {
        Debug.Log(characterName + " dealt damage to the enemy with an attack!");

        if (characterName == "Fighter")
        {
            fighterATB.ActionPerformed();
        }
        else if (characterName == "Swordsman")
        {
            swordsmanATB.ActionPerformed();
        }
        else if (characterName == "Mage")
        {
            mageATB.ActionPerformed();
        }
    }
}