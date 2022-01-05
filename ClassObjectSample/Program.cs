
var goblin = new Card(name: "哥布林", attack: 3, health: 2, description: "Monster");
var warrior = new Card(name: "戰士", attack: 4, health: 3, description: "Human");
warrior.Hit(goblin);

public class Card
{
    public string Name;
    public int Level;
    public int Attack;
    public int Health;
    private string _description = "Undefine";
    public string Description
    {
        set
        {
            if (value.Length > 0 && value.Length < 30)
            {
                this._description = value;
            }
            else
            {
                throw new System.Exception("就跟你說限 30 個字看不懂喔！");
            }

            if (value == "Undead")
            {
                Console.WriteLine(this.Name + " become to undead!");
            }
        }
        get
        {
            return this._description;
        }
    }

    public Card(string name = "Noname", int attack = 5, int health = 5, string description = "Undefine")
    {
        this.Name = name;
        this.Attack = attack;
        this.Health = health;
        this.Description = description;
    }

    public void Hit(Card target)
    {
        target.Health -= this.Attack;
        if (target.Health <= 0)
        {
            Console.WriteLine(this.Name + " is " + this.Description);
            Console.WriteLine(target.Name + " is " + target.Description);
            Console.WriteLine(this.Name + " Attack " + target.Name);
            Console.WriteLine(this.Name + " Attack Value is " + this.Attack);
            Console.WriteLine(target.Name + " Health Value is " + target.Health);
            Console.WriteLine(target.Name + " is death!");
            target.Description = "Undead";
            /*Do Death */
        }
    }
}
