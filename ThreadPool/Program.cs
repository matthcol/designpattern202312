// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

int maxThreads;
int maxPorts;
int availableThreads;
int availablePorts;
ThreadPool.GetMaxThreads(out maxThreads, out maxPorts);
ThreadPool.GetAvailableThreads(out availableThreads, out availablePorts);
Console.WriteLine($"Threads: max={maxThreads}, available={availableThreads}");
Console.WriteLine($"Ports: max={maxPorts}, available={availablePorts}");

var okMin = ThreadPool.SetMinThreads(4, 1000);
var okMax = ThreadPool.SetMaxThreads(4, 1000);
Console.WriteLine($"Change nb of threads: {okMin}, {okMax}");
ThreadLocal<string> ThreadName = new ThreadLocal<string>(() =>
{
    return "Thread" + Thread.CurrentThread.ManagedThreadId;
});

ThreadPool.QueueUserWorkItem(o => Console.WriteLine("Hello from Thread"));

// Action that prints out ThreadName for the current thread
Action<int> action = (i) =>
{
    // If ThreadName.IsValueCreated is true, it means that we are not the
    // first action to run on this thread.
    bool repeat = ThreadName.IsValueCreated;

    Console.WriteLine("Job #{0} affected to Thread: Name = {1} {2}", i, ThreadName.Value, repeat ? "(repeat)" : "");
    Thread.Sleep(500);
};

for (int i = 0; i < 20; i++)
{
    ThreadPool.QueueUserWorkItem(action, i, true);
}

// main thread: wait enough to have all jobs completed
// NB: see  WaitHandle.WaitAll or Barrier class for improvment
Thread.Sleep(4000);