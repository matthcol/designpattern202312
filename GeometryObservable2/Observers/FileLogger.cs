using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Observers
{
    internal class FileLogger : IObserver<AbstractForm>, IDisposable
    {
        private StreamWriter? _stream;

        public FileLogger(string filename) { 
            _stream = new StreamWriter(filename);
        }

        public void Dispose()
        {
            _stream?.Dispose();
            _stream = null;
        }

        public void OnCompleted()
        { 
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(AbstractForm value)
        {
            _stream!.WriteLine(value.ToString());
        }
    }
}
