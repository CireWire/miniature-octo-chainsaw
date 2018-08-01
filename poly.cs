using System;

class MainClass 
{
  class Enemy
  {
    public virtual void Attack()
    {
      Console.WriteLine("Take 15 damage!");
    }
  }

  class Elf:Enemy
  {
    public override void Attack()
    {
      //made up damage amount...
      Console.WriteLine("Take 30 damage!");
    }
  }

  class Orc:Enemy
  {
    public override void Attack()
    {
      //made up damage amount...
      Console.WriteLine("Take 60 damage!");
    }
  }

  public static void Main () 
  {
    Enemy e = new Elf();
    e.Attack();

    Enemy o = new Orc();
    o.Attack();
  }
}
