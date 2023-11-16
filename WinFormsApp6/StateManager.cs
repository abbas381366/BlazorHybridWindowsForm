using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class StateManager
    {
        public event EventHandler OnStatechanged;

        public int Counter { get; set; }

        public void StateChanged()
        {
            OnStatechanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
