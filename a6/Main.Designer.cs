namespace a6;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    // toolbar
    private MenuStrip toolbar;
    // date and time label
    private Label dtLabel;
    // datetime picker
    private DateTimePicker dtPicker;
    // priority label
    private Label priorityLabel;
    // priority combo box
    private ComboBox cmbPriority;
    // To-Do label
    private Label lblTodo;
    // description text box
    private TextBox txtDescription;
    // add button
    private Button btnAdd;
    // To Do group box
    private GroupBox gbTodo;
    // To Do group box date label
    private Label gbDateLabel;
    // To Do group box hour label
    private Label gbHourLabel;
    // To Do group box priority label
    private Label gbPriorityLabel;
    // To Do group box description label
    private Label gbDescriptionLabel;
    // To Do list box
    private ListBox lbTodo;
    // change button
    private Button btnChange;
    // delete button
    private Button btnDelete;
    // clock text box
    private TextBox txtClock;
    // timer
    private System.Windows.Forms.Timer timer;
    // To Do manager
    private ToDoManager toDoManager;
    // current To Do
    private ToDo currentToDo;
    // filemanager
    private FileManager fileManager;

    private int HEIGHT = 480;
    private int WIDTH = 800;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        fileManager = new FileManager();
        toDoManager = new ToDoManager();
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(WIDTH, HEIGHT);
        this.Text = "ToDo Reminder by Drake Axelrod";
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        initToolbar();
        initTopSection();
        initBottomSection();
        initFinalSection();
        // prompt before closing
        this.FormClosing += new FormClosingEventHandler(main_FormClosing);
    }

    /// <summary>
    ///  Initialize the toolbar
    ///  Two buttons: File and Help
    /// </summary>
    private void initToolbar()
    {
        // create the toolbar
        toolbar = new MenuStrip();
        // add the toolbar to the form
        this.Controls.Add(toolbar);
        // create the file menu
        ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
        // create the help menu
        ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
        // add the file menu to the toolbar
        toolbar.Items.Add(fileMenu);
        // add the help menu to the toolbar
        toolbar.Items.Add(helpMenu);
        // create file menu buttons
        ToolStripMenuItem newButton = new ToolStripMenuItem("New");
        // event handler for new button
        newButton.Click += new EventHandler(newButton_Click);
        ToolStripMenuItem openButton = new ToolStripMenuItem("Open data file");
        // event handler for open button
        openButton.Click += new EventHandler(openButton_Click);
        ToolStripMenuItem saveButton = new ToolStripMenuItem("Save data file");
        // event handler for save button
        saveButton.Click += new EventHandler(saveButton_Click);
        ToolStripMenuItem exitButton = new ToolStripMenuItem("Exit");
        // add exit button event handler
        exitButton.Click += new EventHandler(exitButton_Click);
        // add the file menu buttons to the file menu
        fileMenu.DropDownItems.Add(newButton);
        fileMenu.DropDownItems.Add(openButton);
        fileMenu.DropDownItems.Add(saveButton);
        fileMenu.DropDownItems.Add(exitButton);
        // create the about button
        ToolStripMenuItem aboutButton = new ToolStripMenuItem("Something");
        // add the about button to the help menu
        helpMenu.DropDownItems.Add(aboutButton);
        // add the exit button event handler
        // exitButton.Click += new EventHandler(exitButton_Click);
        // // add the about button event handler
        // aboutButton.Click += new EventHandler(aboutButton_Click);
        this.Controls.Add(toolbar);
    }

    /// <summary>
    ///  Initialize
    ///   - date and time label
    ///   - datetime picker
    ///   - priority label
    ///   - priority combo box
    ///   - To-Do label
    ///   - description text box
    ///   - add button
    /// </summary>
    private void initTopSection()
    {
        // looks like this:
        // left aligned Date and Time: [datetime picker] Priority: [combo box]
        // left-aligned To-Do: [text box]
        // centered - [add button]
        
        // date and time label
        dtLabel = new Label();
        dtLabel.Text = "Date and Time";
        dtLabel.Location = new Point(10, 32);
        dtLabel.AutoSize = true;
        this.Controls.Add(dtLabel);
        // datetime picker
        dtPicker = new DateTimePicker();
        dtPicker.Location = new Point(100, 30);
        dtPicker.Format = DateTimePickerFormat.Custom;
        // format yyyy-MM-dd hh:mm
        dtPicker.CustomFormat = "yyyy-MM-dd hh:mm";
        // size to fit
        dtPicker.AutoSize = true;

        this.Controls.Add(dtPicker);
        // priority label
        priorityLabel = new Label();
        priorityLabel.Text = "Priority";
        priorityLabel.Location = new Point(350, 33);
        priorityLabel.AutoSize = true;
        this.Controls.Add(priorityLabel);
        // priority combo box
        cmbPriority = new ComboBox();
        cmbPriority.Location = new Point(400, 30);
        // add enum values to combo box replace _ with space
        cmbPriority.Items.AddRange(Enum.GetNames(typeof(Priority)).Select(x => x.Replace("_", " ")).ToArray());
        cmbPriority.SelectedIndex = 0;
        this.Controls.Add(cmbPriority);
        // To-Do label
        lblTodo = new Label();
        lblTodo.Text = "ToDo";
        lblTodo.Location = new Point(10, 63);
        lblTodo.AutoSize = true;
        this.Controls.Add(lblTodo);
        // description text box
        txtDescription = new TextBox();
        txtDescription.Location = new Point(100, 60);
        txtDescription.Size = new Size(670, 20);
        this.Controls.Add(txtDescription);
        // add button
        btnAdd = new Button();
        btnAdd.Text = "Add";
        // center the button
        btnAdd.Location = new Point((WIDTH - 200) / 2, 90);
        btnAdd.Size = new Size(200, 30);
        btnAdd.Click += new EventHandler(btnAdd_Click);
        this.Controls.Add(btnAdd);
        // focus on the description text box
        txtDescription.Focus();
    }

    /// <summary>
    ///  Initialize the bottom section
    ///   - To Do group box
    ///   - Group box date label
    ///   - Group box hour label
    ///   - Group box priority label
    ///   - Group box description label
    ///   - To Do list box
    ///   - change button
    ///   - delete button
    /// </summary>
    private void initBottomSection()
    {
        // looks like this:
        // To Do
        // Date: [date] Hour: [hour] Priority: [priority]
        // Description: [description]
        // [list box]
        // [change button] [delete button]
        
        // To Do group box
        gbTodo = new GroupBox();
        gbTodo.Text = "To Do";
        gbTodo.Location = new Point(10, 130);
        gbTodo.Size = new Size(780, 300);
        this.Controls.Add(gbTodo);
        // Group box date label
        gbDateLabel = new Label();
        gbDateLabel.Text = "Date";
        gbDateLabel.Location = new Point(20, 20);
        gbDateLabel.AutoSize = true;
        gbTodo.Controls.Add(gbDateLabel);
        // Group box hour label
        gbHourLabel = new Label();
        gbHourLabel.Text = "Hour";
        gbHourLabel.Location = new Point(200, 20);
        gbHourLabel.AutoSize = true;
        gbTodo.Controls.Add(gbHourLabel);
        // Group box priority label
        gbPriorityLabel = new Label();
        gbPriorityLabel.Text = "Priority";
        gbPriorityLabel.Location = new Point(300, 20);
        gbPriorityLabel.AutoSize = true;
        gbTodo.Controls.Add(gbPriorityLabel);
        // Group box description label
        gbDescriptionLabel = new Label();
        gbDescriptionLabel.Text = "Description";
        gbDescriptionLabel.Location = new Point(440, 20);
        gbDescriptionLabel.AutoSize = true;
        gbTodo.Controls.Add(gbDescriptionLabel);
        // To Do list box
        lbTodo = new ListBox();
        lbTodo.Location = new Point(20, 40);
        lbTodo.Size = new Size(740, 250);
        // lbTodo.SelectedIndexChanged += new EventHandler(lbTodo_SelectedIndexChanged);
        gbTodo.Controls.Add(lbTodo);
    }

    /// <summary>
    ///  last section of the form
    ///    - change button
    ///    - delete button
    ///    - clock text box
    /// </summary>
    private void initFinalSection()
    {
        // looks like this:
        // [change button] [delete button]
        // [clock text box]
        
        // change button
        btnChange = new Button();
        btnChange.Text = "Change";
        btnChange.Location = new Point(10, 440);
        btnChange.Size = new Size(200, 30);
        btnChange.Click += new EventHandler(btnChange_Click);
        this.Controls.Add(btnChange);
        // delete button
        btnDelete = new Button();
        btnDelete.Text = "Delete";
        btnDelete.Location = new Point(280, 440);
        btnDelete.Size = new Size(200, 30);
        btnDelete.Click += new EventHandler(btnDelete_Click);
        this.Controls.Add(btnDelete);
        // clock text box
        txtClock = new TextBox();
        txtClock.Location = new Point(710, 440);
        txtClock.Size = new Size(80, 20);
        txtClock.ReadOnly = true;
        // size the text to be 20 pixels high and bold blue
        txtClock.Font = new Font(txtClock.Font.FontFamily, 12, FontStyle.Bold);
        // background same as form
        txtClock.BackColor = this.BackColor;
        // color label text blue
        txtClock.ForeColor = Color.Blue;
        // center the text
        txtClock.TextAlign = HorizontalAlignment.Center;
        timer = new System.Windows.Forms.Timer();
        // get the current time
        DateTime now = DateTime.Now;
        // set the clock text box hour:minute:second
        txtClock.Text = now.ToString("HH:mm:ss");
        // start the timer
        timer.Start();
        // set the timer interval to 1 second
        timer.Interval = 1000;
        timer.Tick += new EventHandler(timer_Tick);
        this.Controls.Add(txtClock);
    }

    /// <summary>
    ///  Clock
    /// </summary>
    private void timer_Tick(object sender, EventArgs e)
    {
        // get the current time
        DateTime now = DateTime.Now;
        // set the clock text box hour:minute:second
        txtClock.Text = now.ToString("HH:mm:ss");
    }

    /// <summary>
    ///  prompt before closing
    /// </summary>
    private void main_FormClosing(object sender, FormClosingEventArgs e)
    {
        // ask if the user wants to close the form
        DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Close Form", MessageBoxButtons.YesNo);
        // if the user does not want to close the form
        if (result == DialogResult.No)
        {
            // cancel the form closing event
            e.Cancel = true;
        }
        else // the user wants to close the form
        {
            // close the form
            e.Cancel = false;
        }
    }

        ///  prompt before closing
    /// </summary>
    private void exitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Add button click event
    /// </summary>
    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (sender == btnAdd) {
        //get date from date picker
        DateTime date = dtPicker.Value;
        //get description from text box
        string description = txtDescription.Text;
        //get priority from combo box to enum type
        string strPriority = cmbPriority.SelectedItem.ToString();
        Priority priority = (Priority)Enum.Parse(typeof(Priority), strPriority.Replace(" ", "_"));
        // make a new todo item
        ToDo item = new ToDo(description, priority, date);
        // add the item to the list
        toDoManager.Add(item);
        lbTodo.Items.Add(item.ToString());
      }
    }

    /// <summary>
    ///  Change button click event
    /// </summary>
    private void btnChange_Click(object sender, EventArgs e)
    {
        // get the selected item
        int index = lbTodo.SelectedIndex;
        // if there is a selected item
        if (index != -1)
        {
            // get the selected item
            ToDo item = toDoManager.Get(index);
            // set current todo item
            currentToDo = item;
            // set the date picker to the date of the selected item
            dtPicker.Value = item.DueDate;
            // set the description text box to the description of the selected item
            txtDescription.Text = item.Description;
            // set the priority combo box to the priority of the selected item
            cmbPriority.SelectedIndex = (int)item.Priority;
            // remove the selected item from the list
            toDoManager.Remove(index);
            lbTodo.Items.RemoveAt(index);
        }
        else
        {
            MessageBox.Show("Please select an item to change.");
        }
    }

    /// <summary>
    ///  Delete button click event
    /// </summary>
    private void btnDelete_Click(object sender, EventArgs e)
    {
        // get the selected item
        int index = lbTodo.SelectedIndex;
        // if there is a selected item
        if (index != -1)
        {
            // remove the selected item from the list
            toDoManager.Remove(index);
            lbTodo.Items.RemoveAt(index);
        }
        else
        {
            MessageBox.Show("Please select an item to delete.");
        }
    }

    /// <summary>
    /// save the list to a file
    /// </summary>
    private void saveButton_Click(object sender, EventArgs e)
    {
        // create a file dialog
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        // set the file dialog title
        saveFileDialog.Title = "Save To Do List";
        // set the file dialog filter json files
        saveFileDialog.Filter = "TXT Files (*.txt)|*.txt";
        // if the user clicked OK
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            // get the file name
            string fileName = saveFileDialog.FileName;
            // save the list to the file
            fileManager.SaveToFile(toDoManager.List, fileName);
        }
    }

    /// <summary>
    /// load the list from a file
    /// </summary>
    private void openButton_Click(object sender, EventArgs e)
    {
        // create a file dialog
        OpenFileDialog openFileDialog = new OpenFileDialog();
        // set the file dialog title
        openFileDialog.Title = "Load To Do List";
        // set the file dialog filter txt files
        openFileDialog.Filter = "TXT Files (*.txt)|*.txt";
        // if the user clicked OK
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // get the file name full path
            string fileName = openFileDialog.FileName;
            // load the list from the file
            toDoManager.List = fileManager.LoadFromFile(fileName);
            // clear the list box
            lbTodo.Items.Clear();
            // add the items to the list box
            foreach (ToDo item in toDoManager.List)
            {
                lbTodo.Items.Add(item.ToString());
            }
        }
    }

    /// <summary>
    ///  new button click event
    /// </summary>
    private void newButton_Click(object sender, EventArgs e)
    {
        // clear the list box
        lbTodo.Items.Clear();
        // clear the list
        toDoManager.List.Clear();
        // clear the date picker
        dtPicker.Value = DateTime.Now;
        // clear the description text box
        txtDescription.Text = "";
        // clear the priority combo box
        cmbPriority.SelectedIndex = 0;
    }
}
