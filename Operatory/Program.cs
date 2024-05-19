using System.Text;

namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Operatory
                Zadanie 1
                    W metodzie Main utwórz 6 zmiennych.
                    Każda zmienna powinna przechowywać odpowiednio dobrany przez Ciebie typ danych na podstawie opisu.
                    Wartości mogą być dowolne.
                    Zmienna o nazwie number przechowująca liczbę całkowitą.
                    Zmienna o nazwie money przechowująca liczbę zmiennoprzecinkową (float).
                    Zmienna o nazwie text przechowująca tekst.
                    Zmienna o nazwie isLogged przechowująca wartość logiczną.
                    Zmienna o nazwie myChar przechowująca pojedynczy znak.
                    Zmienna o nazwie price przechowująca liczbę zmiennoprzecinkową z największą precyzją (decimal).
                    Po deklaracji wszystkich zmiennych wyświetl je w konsoli.
            */
            int number = 15;
            float money = 20.75f;
            string text = "to jest tekst";
            bool isLogged = false;
            char myChar = 'a';
            decimal price = 9.55m;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("IsLogged: " + isLogged);
            Console.WriteLine("MyChar: " + myChar);
            Console.WriteLine("Price: " + price);

            /*
             Zadanie 2
                Utwórz zmienną o nazwie myAge typu string z wartością Age: .
                Utwórz zmienną o nazwie wifeAge typu int z wartością 18.
                Utwórz zmienną o nazwie result i przypisz do niej rezultat dodawania zmiennych myAge i wifeAge.
                Wyświetl zmienną result w konsoli.
                Jakie wnioski?*/
            string myAge = "32";
            int wifeAge = 18;
            var result = myAge + wifeAge;
            Console.WriteLine(result);
            //moglbym tak zrobic ale ma to sredni sens. Jesli chcialbym miec sume jednego i drugiego wieku no to wtedy:
            int myAge2 = Convert.ToInt32(myAge);
            Console.WriteLine(myAge2);
            int result2 = myAge2 + wifeAge;
            Console.WriteLine(result2);
            //albo na samym poczatku zadeklarowalbym jako int obie zmienne.

            /*
            Zadanie 3
                Utwórz 3 zmienne typu bool o następujących nazwach i wartościach:
                    isTrue o wartości true.
                    isFalse o wartości false.
                    isReallyTrue o wartości true.
                Utwórz 3 kolejne zmienne o następujących nazwach i przypisz do nich wyniki działań na zmiennych logicznych:
                    and powinna zwierać wynik działania isTrue AND isFalse.
                    or powinna zwierać wynik działania isTrue OR isReallyTrue.
                    negative powinna zawierać wynik negacji isFalse.
                Wyświetl zmienne and, or i negative w konsoli. 
             */
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);

            /*
             Zadanie 4
                Utwórz dwie zmienne o nazwach a, b i przypisz do nich wartości 5, 12.
                Utwórz zmienne o nazwach add, sub, div, mul, mod i przypisz do nich kolejno wynik dodawania, odejmowania, dzielenia, mnożenia i modulo zmiennych a i b.
                Wyświetl zmienne add, sub, div, mul, mod w konsoli.
             */

            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);

            /*
                Zadanie 5
                    Utwórz trzy zmienne typu string o nazwach a, b i c.
                    Do zmiennych przypisz kolejno tekst Ala , ma , kota..
                    Utwórz 4 zmienną o nazwie result i przypisz do niej wynik operacji a + b + c.
                    Wyświetl zmienną result w konsoli.
                    Napisz w komentarzu swoje spostrzeżenia dotyczące wyniku.
             */
            string aa = "Ala";
            string bb = "ma";
            string cc = "kota";
            string result3 = aa + " " + bb + " " + cc;
            Console.WriteLine(result3);
            //no jedyne spostrzeżenia że trzeba dodać spację :)


        }
    }
}
