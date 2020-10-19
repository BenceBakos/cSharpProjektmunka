using System;
namespace TaskR
{
    public partial class newTask : Gtk.Window
    {
        public newTask() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
