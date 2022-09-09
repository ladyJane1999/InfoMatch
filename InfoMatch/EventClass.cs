using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMatch
{
    public class EventClass : EventArgs
    {
        public event EventHandler<EventArgs>? Event;
        public void onEvent(string msg) {

            Console.WriteLine(msg);
            Event?.Invoke("st", EventArgs.Empty); } 
    }
}
