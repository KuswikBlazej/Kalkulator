namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //1. Wyświetlenie nagłowka - opis aplikacji
                Console.WriteLine("Witaj w aplikacji KALKULATOR!");

                //2. Prośba o podanie 1 liczby
                Console.WriteLine("Podaj proszę 1 liczbę:");

                //3. Pobranie liczby od użytkownika
                var int1 = int.Parse(Console.ReadLine());

                //4. Prośba o podanie działania
                Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

                //5. Pobranie wybranego działania od użytkownika
                var op = Console.ReadLine();

                //6. Prośba o podanie 2 liczby
                Console.WriteLine("Podaj proszę 2 liczbę:");

                //7. Pobranie liczby od użytkownika
                var int2 = int.Parse(Console.ReadLine());

                //8. Wykonanie obliczeń
                var res = 0;

                switch (op)
                {
                    case "+":
                        res = int1 + int2;
                        break;
                    case "-":
                        res = int1 - int2;
                        break;
                    case "*":
                        res = int1 * int2;
                        break;
                    case "/":
                        res = int1 / int2;
                        break;
                    default:
                        throw new Exception("Wybrałeś złą operację!");
                }

                //9. Wyświetlenie wyniku użytkownikowi
                Console.WriteLine($"Wynik Twojego działania to: {res}.");

            }
            catch (Exception ex)
            {
                //logowanie do pliku
                Console.WriteLine(ex.Message);
            }
        }

    }
}