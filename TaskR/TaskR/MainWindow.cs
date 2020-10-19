using System;
using Gtk;
using TaskR;

/*
TODO:
- HTTPClient.sendCommand --> curl/httpclient (curl may be a better option), contructor
- NewTaskDialog.saveTask
- MainWindow.showArchived,refresh, refreshTasks
- Task.getAllTask,newTask,archive,restore,change
*/

public partial class MainWindow : Gtk.Window
{
    private bool showArchived = false;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void newTaskDialog(object sender, EventArgs e)
    {
        NewTaskDialog taskDialog = new NewTaskDialog();

        taskDialog.Show();

    }

    protected void showArchived(object sender, EventArgs e)
    {
        //rerender all from api!
        //also change showArchived
    }

    protected void refreshTasks(object sender, EventArgs e)
    {
        //refresh tasks, keep state of showArchived
    }

    private bool refresh(bool isArchived) {
        //return true--> success, false -->show config error as popup IN THIS METOHD
        //refresh from api
    }
}
