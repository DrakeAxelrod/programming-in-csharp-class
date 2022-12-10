namespace a6;

public class FileManager {

  /// <summary>
  ///  Default constructor.
  /// </summary>
  public FileManager() {}

  /// <summary>
  ///  Saves the list of ToDos to a file.
  /// </summary>
  public void SaveToFile(List<ToDo> toDoList, string path) {
    // create file
    using (StreamWriter sw = File.CreateText(path)) {
      // lines for each ToDo date;priority;description
      foreach (ToDo toDo in toDoList) {
        string date = toDo.DueDate.ToString("yyyy-MM-dd_HH-mm-ss");
        string priority = toDo.Priority.ToString();
        string description = toDo.Description;
        sw.WriteLine($"{date};{priority};{description}");
      }
    }
  }

  /// <summary>
  ///  Loads the list of ToDos from a file.
  /// </summary>
  public List<ToDo> LoadFromFile(string path) {
    // check if file exists
    if (!File.Exists(path)) {
      throw new FileNotFoundException();
    }
    // read file
    List<ToDo> toDoList = new List<ToDo>();
    using (StreamReader sr = File.OpenText(path)) {
      string line;
      while ((line = sr.ReadLine()) != null) {
        // split line
        string[] lineSplit = line.Split(';');
        // create ToDo
        // date format: yyyy-MM-dd_HH-mm-ss
        string[] dateSplit = lineSplit[0].Split('_');
        string[] dateSplit2 = dateSplit[0].Split('-');
        string[] timeSplit = dateSplit[1].Split('-');
        int year = int.Parse(dateSplit2[0]);
        int month = int.Parse(dateSplit2[1]);
        int day = int.Parse(dateSplit2[2]);
        int hour = int.Parse(timeSplit[0]);
        int minute = int.Parse(timeSplit[1]);
        int second = int.Parse(timeSplit[2]);
        DateTime dueDate = new DateTime(year, month, day, hour, minute, second);
        Priority priority = (Priority)Enum.Parse(typeof(Priority), lineSplit[1]);
        string description = lineSplit[2];
        ToDo toDo = new ToDo(description, priority, dueDate);
        // add to list
        toDoList.Add(toDo);
      }
    }
    return toDoList;
  }
}
