using System.ComponentModel;

namespace gb_OOP
{
    internal class FamilyMember
    {
        private const char LineSymbol = '|';
        public Person Root { get; set; }
        public FamilyMember(Person root)
        {
            Root = root;
        }

        public void AddChild(Person parent, Person child)
        {
            if(parent.Gender == Gender.Female) 
            {
                throw new ArgumentException("Женщина не может иметь детей");
            }
            
            parent.Children.Add(child);
            child.Children.Add(parent);
        }
        public void AddSpouse(Person person, Person spouse)
        {
            if (person.Spouse != null)
            {
                throw new ArgumentException("Персона уже состоит в браке");
            }

            if (spouse.Spouse != null)
            {
                throw new ArgumentException("Персона уже состоит в браке");
            }


            person.Spouse = spouse;
            spouse.Spouse = person;
        }
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }
        private void PrintTree(Person person, int level)
        {
            Person parent = person;
            for (int i = 0;i< level; i++)
            {
                Console.WriteLine("   ");
            }
            Console.WriteLine("{0} ({1})", person.Name, person.Gender);
            for (int i = 0; i < person.Children.Count; i++)
            {
                PrintTree(person.Children[i], level + 1);
            }
            for (int i = 0; i < person.Children.Count; i++)
            {
                Console.WriteLine(new string(LineSymbol, level+1));
                PrintTree(person.Children[i], level+1);
            }

            // Отступы
            Console.Write(new string(' ', level * 4));

            // Вертикальная линия
            Console.WriteLine(new string('|', level));

            // Информация о person
            Console.WriteLine("{0} ({1})", person.Name, person.Gender);

            // Супруг(а)
            if (person.Spouse != null)
            {
                Console.WriteLine("{0,-20} ({1})", person.Spouse.Name, person.Spouse.Gender);
            }

            // Горизонтальная линия между поколениями
            if (level > 0)
            {
                Console.WriteLine(new string('-', 40));
            }

            // Дочерние элементы
            foreach (var child in person.Children)
            {
                // Горизонтальная линия к дочернему элементу
                Console.Write(new string('|', level + 1));

                PrintTree(child, level + 1);
            }
            //выводим жену
            if (person.Spouse != null)
            {
                Console.WriteLine();
                Console.WriteLine("{0} ({1})", person.Spouse.Name, person.Spouse.Gender);
            }

        }
        private void PrintLine(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.WriteLine("   ");
            }
        }
    }
}