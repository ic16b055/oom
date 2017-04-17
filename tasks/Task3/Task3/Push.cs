using System;
using System.Reactive.Linq;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using static System.Console;


namespace Task3
{
    class Push
    {
        public static void Run()
        {
            var window = new Form() { Text = "Task3", Width = 500, Height = 500 };

          
            IObservable<Point> moves = Observable.FromEventPattern<MouseEventArgs>(window, "MouseMove").Select(x => x.EventArgs.Location);

            moves
                .Throttle(TimeSpan.FromSeconds(0.2))
                .DistinctUntilChanged()
                .Subscribe(e => WriteLine($"[D] ({e.X}, {e.Y})"))
                ;

            Application.Run(window);
        }
    }
}
