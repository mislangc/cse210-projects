using System;

public class Player : Entity
{
    private string _weaponName;
    private int _weaponAttack;

    public Player(string name) : base(name)
    {
        _level = 1;
        _coins = 0;
        _health = 10;
        _baseAttack = 2;
        _xp = 0;
        _weaponName = "none";
        _weaponAttack = 0;
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
}