using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

public class Character
{
    public string name;
    public int health;
    public int attackPower;

    public Character(string name, int health, int attackPower)
    {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
    }
}