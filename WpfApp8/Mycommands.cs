using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp8
{
    class Mycommands
    {
        public static RoutedUICommand Exit { get; set; }

        static Mycommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(Mycommands), inputs);
        }
    }
}
