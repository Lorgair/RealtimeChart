using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mySafeThreads
{     
    public class SafeThread
{
    ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
    ManualResetEvent _pauseEvent = new ManualResetEvent(true);
    Thread _thread;

    public SafeThread() { }

    public void Start()
    {
        _thread = new Thread(DoWork);
        _thread.Start();
    }

    public void Pause()
    {
        _pauseEvent.Reset();
    }

    public void Resume()
    {
        _pauseEvent.Set();
    }

    public void Stop()
    {
        // Signal the shutdown event
        _shutdownEvent.Set();

        // Make sure to resume any paused threads
        _pauseEvent.Set();

        // Wait for the thread to exit
        _thread.Join();
    }

    public void DoWork()
    {
        while (true)
        {
            _pauseEvent.WaitOne(Timeout.Infinite);

            if (_shutdownEvent.WaitOne(0))
                break;

            // Do the work..
        }
    }
}
    
}
