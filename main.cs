using System;

class MainClass 
{

  static public int playerHealth = 20;


  public static void Main (string[] args) 
  {
    Battle("Artimus", 20);
  }

  //
  public static void Battle(string enemy, int enemyHealth) 
  {
    Console.WriteLine("You go to battle against " + enemy + " ...");
    DisplayHealth(playerHealth, enemyHealth);

    do {
      Console.Write("You prepare to attack...(press enter)");
      Console.ReadLine();

      int damage = new Random().Next(10);
      Console.WriteLine("...and strike for " + damage + " damage!");

      enemyHealth -= damage;
      if (enemyHealth < 0)
        enemyHealth = 0;
      DisplayHealth(playerHealth, enemyHealth);

        if (enemyHealth > 0)  {
        Console.Write(enemy + "Prepares to attack...(press enter)");
        Console.ReadLine();

        damage = new Random().Next(10);
        Console.WriteLine("...and strikes for " + damage + " damage!");

        playerHealth -= damage;
        if (playerHealth <0)
          playerHealth = 0;
        DisplayHealth(playerHealth, enemyHealth);
        }

    } while(playerHealth > 0 && enemyHealth > 0);

    if (playerHealth > 0) 
    {
      Console.WriteLine(enemy + " falls to the ground, defeated.");
    }
    else 
    {
      Console.WriteLine("You stumble to the ground in defeat.");
    }

  }

  public static void DisplayHealth(int p, int e) 
  {
    Console.WriteLine("Player: " + p);
    Console.WriteLine("Enemy: " + e + "\n\r");
  }

}