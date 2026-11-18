
List<string> tasks = new();

while (true)
{
    Console.WriteLine("\n=== TO-DO LIST MANAGER ===");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Remove Task");
    Console.WriteLine("3. List Tasks");
    Console.WriteLine("4. Quit");
    Console.Write("Select an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddTask();
            break;

        case "2":
            RemoveTask();
            break;

        case "3":
            ListTasks();
            break;

        case "4":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

void AddTask()
{
    while (true)
    {
        Console.WriteLine("Enter Task:");
        string? task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("Task cannot be empty!");
            continue;
        }
        tasks.Add(task.Trim());
        Console.WriteLine("Task added successfully!");
        break;
    }
}

void RemoveTask()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks to remove.");
        return;
    }

    int i = 1;
    foreach (var task in tasks)
    {
        Console.WriteLine($"Task{i}: {task} ");
        i++;
    }


    while (true)
    {
        Console.WriteLine("Choose a task number to remove:");
        string? selectedTask = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(selectedTask))
        {
            Console.WriteLine("Please select an option!");
            continue;
        }        

        if (!int.TryParse(selectedTask, out int taskNumber))
        {
            Console.WriteLine("Please enter a valid number.");
            continue;
            
        }
        if (taskNumber < 1 || taskNumber > tasks.Count)
        {
            Console.WriteLine("Task number is out of range.");
            continue;
        }
        tasks.RemoveAt(taskNumber - 1);
        Console.WriteLine("Task removed successfully.");
        break;
    }

}

void ListTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    Console.WriteLine("\n=== YOUR TASKS ===");

    int i = 1;
    foreach (string task in tasks)
    {
        Console.WriteLine($"Task {i}: {task}");
        i++;
    }
}
