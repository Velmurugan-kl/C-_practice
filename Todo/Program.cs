

List<string> list = new List<string>();
string choice ="";
do
{
    Console.WriteLine("Hello!\r\nWhat do you want to do?\r\n[S]ee all TODOs\r\n[A]dd a TODO\r\n[R]emove a TODO\r\n[E]xit\r\n");
    choice = Console.ReadLine();
    HandleChoice(choice.ToUpper());
    
}
while (choice.ToUpper() != "E");

void HandleChoice(string choice)
{
    Console.WriteLine($"{choice} is selected");
    switch (choice)
    {
        case "S":
            PrintTodo();
            break;
        case "A":
            Console.WriteLine("Enter the TODO description:");
            var description = Console.ReadLine();
            list.Add(description);
            Console.WriteLine($"TODO successfully added: {description}" );
            break;
        case "R":
            PrintTodo();
            Console.WriteLine("Select the index of the TODO you want to remove:");
            int index;
            int.TryParse(Console.ReadLine(), out index);
            RemoveTodo(index);
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }

}

void RemoveTodo(int index)
{
    if(index == 0) { return; }
    string desc = list[index - 1];
    list.RemoveAt(index - 1);
    Console.WriteLine($"TODO removed: {desc}");
}

void PrintTodo()
{
    if(list.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    for(int i = 0;i< list.Count; i++)
    {
        Console.WriteLine($"{i+1}. {list[i]}");
    }
}