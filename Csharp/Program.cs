using System;
using System.Globalization;
using System.Numerics;

// 객체 (OOP Object Oriented Programming)

// Knight
// 속성: hp, attak
// 기능: Move, Attack, Die

// Ref. 참조
class Knight
{
    public int hp;
    public int attack;

    public void Move()
    {
        Console.WriteLine("Knight Move");
    }

    public void Attack() 
    {
        Console.WriteLine("Knight Attack");
    }
}
// 복사
struct Mage
{
    public int hp;
    public int attack;
}

class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight();

        knight.hp = 100;
        knight.attack = 10;

        knight.Move();
        knight.Attack();
    }
}
