namespace a6;

public class FileManager {

  /// <summary>
  ///  Default constructor.
  /// </summary>
  public FileManager() {}

  /// <summary>
  ///  Saves the list of ToDos to a file.
  ///  format: json
  ///  [
  ///    {
  ///      "description": "description",
  ///      "priority": "priority",
  ///      "dueDate": "dueDate"
  ///    },
  ///  ]
  /// </summary>
  public void SaveToFile(List<ToDo> toDoList, string path) {
    // append .json if not present
    if (!path.Contains(".json")) {
      path += ".json";
    }
    using (StreamWriter sw = new StreamWriter(path)) {
      sw.WriteLine("[");
      for (int i = 0; i < toDoList.Count(); i++) {
        sw.WriteLine("  {");
        sw.WriteLine($"    \"description\": \"{toDoList[i].Description}\",");
        sw.WriteLine($"    \"priority\": \"{toDoList[i].Priority}\",");
        sw.WriteLine($"    \"dueDate\": \"{toDoList[i].DueDate}\"");
        sw.WriteLine("  }" + (i < toDoList.Count - 1 ? "," : ""));
      }
      sw.WriteLine("]");
    }
  }

  /// <summary>
  ///  Loads the list of ToDos from a file.
  /// </summary>
  public List<ToDo> LoadFromFile(string path) {
    // check if file exists
    if (!File.Exists(path)) {
      Console.WriteLine("File does not exist.");
      return new List<ToDo>();
    }
    List<ToDo> toDoList = new List<ToDo>();
    using (StreamReader sr = new StreamReader(path)) {
      try {
        string line;
        while ((line = sr.ReadLine()) != null) {
          if (line.Contains("description")) {
            string description = "";
            string priority = "";
            string dueDate = "";
            description = line.Substring(line.IndexOf(":") + 2, line.Length - line.IndexOf(":") - 3);
            line = sr.ReadLine();
            if (line != null) {
              priority = line.Substring(line.IndexOf(":") + 2, line.Length - line.IndexOf(":") - 3);
            }
            line = sr.ReadLine();
            if (line != null) {
              dueDate = line.Substring(line.IndexOf(":") + 2, line.Length - line.IndexOf(":") - 3);
            }
            toDoList.Add(new ToDo(description, (Priority)Enum.Parse(typeof(Priority), priority), DateTime.Parse(dueDate)));
          }
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return new List<ToDo>();
      }
    }
    return toDoList;
  }
}
