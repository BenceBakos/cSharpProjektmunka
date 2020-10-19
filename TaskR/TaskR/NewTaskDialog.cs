using System;
namespace TaskR
{
    public partial class NewTaskDialog : Gtk.Dialog
    {
        public NewTaskDialog()
        {
            this.Build();
        }

        protected void cancel(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void saveTask(object sender, EventArgs e)
        {
            //parse input

            //save, wait for response, show dialog in case of error
        }
    }
}
