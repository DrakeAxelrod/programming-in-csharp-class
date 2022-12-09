namespace a6;

public class FileManager {

  /// <summary>
  ///  Default constructor.
  /// </summary>
  public FileManager() {}

  /// <summary>
  ///  Saves the list of ToDos to a file.
  /// </summary>
  public void Save(List<ToDo> toDoList, string fileName) {
    using (StreamWriter writer = new StreamWriter(fileName)) {
      foreach (ToDo toDo in toDoList) {
        writer.WriteLine(toDo.ToString());
      }
    }
  }

  /// <summary>
  ///  Loads the list of ToDos from a file.
  /// </summary>
  public List<ToDo> Load(string fileName) {
    List<ToDo> toDoList = new List<ToDo>();
    using (StreamReader reader = new StreamReader(fileName)) {
      string line;
      try {
        while ((line = reader.ReadLine()) != null) {
          string[] parts = line.Split(' ');
          DateTime dueDate = DateTime.Parse(parts[0] + " " + parts[1]);
          Priority priority = (Priority)Enum.Parse(typeof(Priority), parts[2]);
          string description = "";
          for (int i = 3; i < parts.Length; i++) {
            description += parts[i] + " ";
          }
          ToDo toDo = new ToDo(description, priority, dueDate);
          toDoList.Add(toDo);
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("Error: " + e.Message);
      }
    }
    return toDoList;
  }
}
