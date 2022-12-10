namespace a6;

public class ToDoManager {
  private List<ToDo> toDoList = new List<ToDo>();

  /// <summary>
  ///  Default constructor.
  /// </summary>
  public ToDoManager() {}

  /// <summary>
  ///  Adds a ToDo to the list.
  /// </summary>
  public void Add(ToDo toDo) {
    toDoList.Add(toDo);
  }

  /// <summary>
  ///  Gets a ToDo from the list.
  /// </summary>
  public ToDo Get(int index) {
    return toDoList[index];
  }

  /// <summary>
  ///  Removes a ToDo from the list.
  /// </summary>
  public void Remove(ToDo toDo) {
    toDoList.Remove(toDo);
  }

  /// <summary>
  ///  Removes a ToDo from the list by index.
  /// </summary>
  public void Remove(int index) {
    toDoList.RemoveAt(index);
  }


  /// <summary>
  /// setter / getter for the list.
  /// </summary>
  public List<ToDo> List {
    get { return toDoList; }
    set { toDoList = value; }
  }

  /// <summary>
  /// Search removal by description.
  /// </summary>
  public void RemoveByDescription(string description) {
    for (int i = 0; i < toDoList.Count; i++) {
      if (toDoList[i].Description == description) {
        toDoList.RemoveAt(i);
        i--;
      }
    }
  }

  /// <summary>
  /// Count of ToDos.
  /// </summary>
  public int Count() {
    return toDoList.Count;
  }

  /// <summary>
  ///  toString override.
  /// </summary>
  public override string ToString() {
    string output = "";
    for (int i = 0; i < toDoList.Count; i++) {
      output += $"{i + 1}. {toDoList[i].Description} ({toDoList[i].Priority}) {toDoList[i].DueDate} {Environment.NewLine}";
    }
    return output;
  }
}
