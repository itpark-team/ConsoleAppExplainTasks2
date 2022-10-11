namespace ConsoleAppExplainTasks2;

public class TasksManager
{
    public void Work(int workerNumber, int duration)
    {
        Console.WriteLine($"{workerNumber} started work at thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(duration);
        throw new Exception("aaaaaaaa error!!");
        Console.WriteLine($"{workerNumber} finished work");
    }

    public async Task WorkAsync(int workerNumber, int duration)
    {
        try
        {
            await Task.Run(() => { Work(workerNumber, duration); });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public int GetMul(int workerNumber, int duration, int number)
    {
        Console.WriteLine($"{workerNumber} started work at thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(duration);
        Console.WriteLine($"{workerNumber} finished work, prepare to return");
        return number * number;
    }
    
    public async Task<int> GetMulAsync(int workerNumber, int duration, int number)
    {
        return await Task.Run(() => GetMul(workerNumber, duration, number));
    }
}