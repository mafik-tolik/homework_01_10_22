//Это библитоека методов (чтобы в дальнейшем обращаться к методам). Актуально, когда рабочий и текущий файл находятся в одной рабочей папке (чтобы библиотека была не на стороннем сервисе). 

// К библиотеке подключаемся через "using <namespace>". Делаем это из файла, в который нужно передать метод из текущей библиотеки/<namespace>. Пример заполнения: <using LibraryHelp;>.
// Но если мы напрямую обращаемся к методу через "namespace.class.<название метода, который вызываем>", то в рабочем файле мы не указываем "using <namespace>" (<using LibraryHelp;>).
// Если бы <namespace> при вызове метода не указывали, то тогда обязательно для подключения к библиотеке нужно указывать "using <namespace>" (<using LibraryHelp;>).

// Для обращения к библиотеке с вызовом метода нужно выполнить: <LibraryHelp.Methods.Help> ("namespace.class.<название метода, который вызываем>").

// В текущем файле перед  названием метода обязательно указываем <public static> (пример: <public static void Help()>). 
// <public> - по умолчанию всё считается приватным, если не указано другое. Поэтому мы делает метод публичным через <public>.
// <static> - делает метод постоянным. Теперь этот метод существует не зависимо от экземпляров объекта (существует в единственном виде для всех, и все другие о нем знают).

namespace LibraryHelp
{
    class Methods
    {
        public static void FillArray(int[] num1, int minValue = 0, int MaxValue = 100) // <minValue = 0, int MaxValue = 100> - так мы указываем значения <0> и <100> по =>
        // => умолчанию. Так, если при вызове метода <FillArray> не указываать <minValue>, <MaxValue>, то ошибки не будет (подставятся значения по умолчанию). 
        {
            MaxValue++;
            Random random = new Random();
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = random.Next(minValue, MaxValue);
            }
        }

        public static void PrintArray(int[] num2)
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write(num2[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
