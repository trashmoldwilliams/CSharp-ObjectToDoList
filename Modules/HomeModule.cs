using Nancy;
using System.Collections.Generic;
using TaskList;
using System;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["addtask.cshtml"];

      Post["/view_tasks"] = _ => {
        Task newTask = new Task(Request.Form["add-task"]);
        newTask.Save();
        List<Task> theTasks = Task.GetAllTasks();
        return View["viewtask.cshtml", theTasks];
      };
      Post["/tasks_cleared"] = _ => {
        Task.ClearAllTasks();
        return View["addtask.cshtml"];
      };
    }
  }
}
