using ConsoleAppExplainTasks2;

TasksManager tasksManager = new TasksManager();

Console.WriteLine($"Main started at thread {Thread.CurrentThread.ManagedThreadId}");

// int res = await tasksManager.GetMulAsync(1, 3000, 2);
//
// Console.WriteLine("return to Main from worker 1");

await tasksManager.WorkAsync(1,1000);

Console.WriteLine("return to Main from worker 1");
//
// await tasksManager.WorkAsync(2,1500);
//
// Console.WriteLine("return to Main from worker 2");
//
// await tasksManager.WorkAsync(3,2000);
//
// Console.WriteLine("return to Main from worker 3");

Console.WriteLine($"Main finished at thread {Thread.CurrentThread.ManagedThreadId}");