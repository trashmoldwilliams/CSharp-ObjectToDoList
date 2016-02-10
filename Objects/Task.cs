using System.Collections.Generic;
using System;

namespace TaskList
{
  public class Task
  {
    private string _taskDescription;
    private int _id;
    private static List<Task> _taskList = new List<Task> {};

    public Task(string taskDescription)
    {
      _taskDescription = taskDescription;
      // _taskList.Add(this);
      _id = _taskList.Count;
    }

    public string GetTaskDescription()
    {
      return _taskDescription;
    }

    public void SetTaskDescription(string anDescription)
    {
      _taskDescription = anDescription;
    }

    public int GetIdentification()
    {
      return _id;
    }

    public static List<Task> GetAllTasks()
    {
      return _taskList;
    }

    public static void ClearAllTasks()
    {
      _taskList.Clear();
    }
    public static Task FindById(int FindId)
    {
      return _taskList[FindId-1];
    }

    public void Save()
    {
      _taskList.Add(this);
    }
    public static void ClearList()
    {
      _taskList.Clear();
    }
  }
}
