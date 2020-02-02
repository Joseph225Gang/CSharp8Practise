using System;
using System.Collections.Generic;
using System.Text;

namespace OtherLanguageSample
{
    class DisposableResource : IDisposable
    {
        public string Value => "disposable-resource";

        public void Dispose()
        {
            Console.WriteLine("Dispose Finish!");
        }
    }
}
