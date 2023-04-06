using System.Text;
using System.Threading.Tasks;
namespace Light
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            int health = 5, maxhealth = 10;
            int mana = 7, maxmana = 10;
            while (true)
            { 
                DrawBar(health,maxhealth,ConsoleColor.Red,0);
                DrawBar(mana, maxmana, ConsoleColor.Green, 2, '&');
            Console.SetCursorPosition(0,5);
                Console.Write("Введите число,на которое изменится жизни: ");
                health+=Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число,на которое изменится мана: ");
                mana+=Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
           
        }
        static void DrawBar(int value, int maxValue, ConsoleColor color,int position,char symbol='@')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write("{");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";
            for (int i = value; i < maxValue; i++)
            {
                bar += "  ";
            }
            Console.Write(bar + " }");
        }
    }
}