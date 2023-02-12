using System;

public class Player : Entity
{
    private string _weaponName;
    private int _weaponAttack;
    private int _maxHealth;
    private int _maxXP;
    private int _healthPotionCount;

    public Player(string name) : base(name)
    {
        _level = 1;
        _coins = 0;
        _health = 10;
        _maxHealth = 10;
        _baseAttack = 2;
        _xp = 0;
        _maxXP = 10;
        _weaponName = "none";
        _weaponAttack = 0;
        _healthPotionCount = 0;
    }
    public Player(string name, int level, int coins, int health, int baseAttack, int xp, int weaponAttack, string weaponName) : base(name, level, coins, health, baseAttack, xp)
    {
        _weaponName = weaponName;
        _weaponAttack = weaponAttack;
    }
    public void SetWeaponName(string weaponName)
    {
        _weaponName = weaponName;
    }
    public void SetWeaponAttack(int weaponAttack)
    {
        _weaponAttack = weaponAttack;
    }
    public string GetWeaponName()
    {
        return _weaponName;
    }
    public int GetWeaponAttack()
    {
        return _weaponAttack;
    }
    public void SetMaxHealth(int maxHealth)
    {
        _maxHealth = maxHealth;
    }
    public int GetMaxHealth()
    {
        return _maxHealth;
    }
    public void SetMaxXp(int maxXp)
    {
        _maxXP = maxXp;
    }
    public int GetMaxXp()
    {
        return _maxXP;
    }
    public void SetHealthPotionCount(int healthPotionCount)
    {
        _healthPotionCount = healthPotionCount;
    }
    public int GetHealthPotionCount()
    {
        return _healthPotionCount;
    }





    public void CheckLevel()
    {
        if (_xp >= _maxXP)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        _level += 1;
        _baseAttack += 1;
        _xp = _xp - _maxXP;
        _maxHealth += 5;
        _maxXP += 10;
        _health = _maxHealth;
        
    }
}