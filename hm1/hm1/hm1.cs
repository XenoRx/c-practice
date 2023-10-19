using gb_OOP;
Person root = new Person("Иван", Gender.Male);
Person child1 = new Person("Сергей", Gender.Male);
Person child2 = new Person("Анна", Gender.Female);
FamilyMember family = new FamilyMember(root);

root.Children.Add(child1);
root.Children.Add(child2);

family.AddSpouse(root, new Person("Александра", Gender.Female));
family.AddSpouse(child1, new Person("Екатерина", Gender.Female));

FamilyMember tree = new FamilyMember(root);

tree.PrintTree();