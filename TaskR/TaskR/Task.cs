using System;
namespace TaskR
{
    public class Task
    {
        public string name { get; private set; }
        public string date { get; private set; }
        public int estimation { get; private set; }
        public bool archived { get; private set; }

        public Task(string name, string date, int estimation, bool archived)
        {
            this.name = name;
            this.date = date;
            this.estimation = estimation;
            this.archived = archived;
        }

        //static methods to create and get tasks
        public static Task[] getAllTask()
        {
            //api/saveall
            //parse json repsonse
        }

        public static CommandResult newTask(string name,int estimation,string date)
        {
            //api/new/name/date/estimation_in_hours
        }

        //methods on current instance

        public CommandResult archive()
        {
            //api/archive/name
        }

        public CommandResult restore()
        {
            //api/restore/name
        }

        public CommandResult change (string fieldName, string newVal)
        {
            //api/change/name/fieldName/newValue
        }
    }
}
