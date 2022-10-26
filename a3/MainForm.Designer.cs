namespace a3;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // saving plan components
    private System.Windows.Forms.GroupBox savingPlanGroupBox;
    private System.Windows.Forms.Label savingsAmountLabel;
    private System.Windows.Forms.TextBox savingsAmountTextBox;
    private System.Windows.Forms.Label monthlyDepositLabel;
    private System.Windows.Forms.TextBox monthlyDepositTextBox;
    private System.Windows.Forms.Label yearsLabel;
    private System.Windows.Forms.TextBox yearsTextBox;
    private System.Windows.Forms.Label interestRateLabel;
    private System.Windows.Forms.TextBox interestRateTextBox;
    private System.Windows.Forms.Label feesLabel;
    private System.Windows.Forms.TextBox feesTextBox;

    private System.Windows.Forms.GroupBox savingPlanResultsGroupBox;
    private System.Windows.Forms.Label amountPaidLabel;
    private System.Windows.Forms.TextBox amountPaidTextBox;
    private System.Windows.Forms.Label amountEarnedLabel;
    private System.Windows.Forms.TextBox amountEarnedTextBox;
    private System.Windows.Forms.Label finalBalanceLabel;
    private System.Windows.Forms.TextBox finalBalanceTextBox;
    private System.Windows.Forms.Label totalFeesLabel;
    private System.Windows.Forms.TextBox totalFeesTextBox;

    private System.Windows.Forms.Button calculateSavingsButton;

    // bmi visual components
    private System.Windows.Forms.GroupBox bmiGroupBox;
    private System.Windows.Forms.GroupBox unitGroupBox;
    private System.Windows.Forms.RadioButton metricRadioButton;
    private System.Windows.Forms.RadioButton imperialRadioButton;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.Label heightLabel;
    private System.Windows.Forms.TextBox metricHeightTextBox;

    private System.Windows.Forms.TextBox imperialHeightFeetTextBox;
    private System.Windows.Forms.TextBox imperialHeightInchesTextBox;
    private System.Windows.Forms.Label weightLabel;
    private System.Windows.Forms.TextBox weightTextBox;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.GroupBox resultGroupBox;
    private System.Windows.Forms.Label bmiLabel;
    private System.Windows.Forms.TextBox bmiTextBox;
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.TextBox categoryTextBox;

    // bmr visual components
    private System.Windows.Forms.GroupBox bmrGroupBox;
    private System.Windows.Forms.GroupBox genderGroupBox;
    private System.Windows.Forms.GroupBox activityGroupBox;
    private System.Windows.Forms.Button calculateBMRButton;


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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 700);
        this.Text = "Super Calculator by Drake Axelrod";

        // add a group box bmi calculator
        this.bmiGroupBox = createGroupBox("BMI Calculator", 10, 10, 300, 130);
        this.Controls.Add(this.bmiGroupBox);
        // add a group box for Units next to the bmi group box
        this.unitGroupBox = createGroupBox("Units", 320, 10, 130, 70);
        this.Controls.Add(this.unitGroupBox);
        // radio buttons for units in the unit group box
        this.metricRadioButton = createRadioButton("metricRadioButton", "Metric (kg, cm)", 10, 20, 110, 20, 0);
        this.unitGroupBox.Controls.Add(this.metricRadioButton);
        // check the metric radio button by default
        this.metricRadioButton.Checked = true;
        this.imperialRadioButton = createRadioButton("imperialRadioButton", "Imperial (ft, lbs)", 10, 40, 110, 20, 0);
        this.unitGroupBox.Controls.Add(this.imperialRadioButton);
        // add event handler for radio buttons
        this.metricRadioButton.CheckedChanged += new System.EventHandler(this.unitRadioHandler);
        this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.unitRadioHandler);
        // add a label for name and an input box next to it
        this.nameLabel = createLabel("nameLabel", "Name", 20, 30, 80, 20, 1);
        this.bmiGroupBox.Controls.Add(this.nameLabel);
        this.nameTextBox = createTextBox("nameTextBox", 100, 27, 180, 20, 1);
        this.bmiGroupBox.Controls.Add(this.nameTextBox);
        this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

        // add a label for height and an input box next to it
        this.heightLabel = createLabel("heightLabel", "Height (cm)", 20, 60, 80, 20, 1);
        this.bmiGroupBox.Controls.Add(this.heightLabel);
        this.metricHeightTextBox = createTextBox("heightTextBox", 100, 57, 180, 20, 1);
        this.imperialHeightFeetTextBox = createTextBox("heightTextBox", 100, 57, 90, 20, 1);
        this.imperialHeightInchesTextBox = createTextBox("heightTextBox", 190, 57, 90, 20, 1);
        this.bmiGroupBox.Controls.Add(this.metricHeightTextBox);
        this.metricHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.imperialHeightFeetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.imperialHeightInchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // restrict input to numbers only
        this.metricHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
        this.imperialHeightFeetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
        this.imperialHeightInchesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);


        // add a label for weight and an input box next to it
        this.weightLabel = createLabel("weightLabel", "Weight (kg)", 20, 90, 80, 30, 1);
        this.bmiGroupBox.Controls.Add(this.weightLabel);
        this.weightTextBox = createTextBox("weightTextBox", 100, 87, 180, 20, 1);
        this.bmiGroupBox.Controls.Add(this.weightTextBox);
        this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // restrict input to numbers only
        this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
        // add a button to calculate the bmi under the bmi group box
        this.calculateButton = createButton("calculateButton", "Calculate BMI", 320, 90, 130, 50, 1);
        this.Controls.Add(this.calculateButton);
        // add event handler for calculate button
        this.calculateButton.Click += new System.EventHandler(this.calculateButtonHandler);
        // make button inactive until all fields are filled
        this.calculateButton.Enabled = false;
        // add event handler for active/inactive button
        this.nameTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);
        this.metricHeightTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);
        this.imperialHeightFeetTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);
        this.imperialHeightInchesTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);
        this.weightTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);

        // create a group box for the bmi results
        // get the content of nameTextBox
        this.resultGroupBox = createGroupBox("Click 'Calculate BMI' for results", 10, 150, 440, 200);
        this.Controls.Add(this.resultGroupBox);
        // add a label for bmi and an input box next to it
        this.bmiLabel = createLabel("bmiLabel", "BMI", 20, 30, 80, 20, 1);
        this.resultGroupBox.Controls.Add(this.bmiLabel);
        this.bmiTextBox = createTextBox("bmiTextBox", 100, 27, 180, 20, 1);
        this.resultGroupBox.Controls.Add(this.bmiTextBox);
        this.bmiTextBox.ReadOnly = true;
        // make the bmi text box hidden
        // this.bmiTextBox.Visible = false;
        // add a label for category and an input box next to it
        this.categoryLabel = createLabel("categoryLabel", "Category", 20, 60, 80, 20, 1);
        this.resultGroupBox.Controls.Add(this.categoryLabel);
        this.categoryTextBox = createTextBox("categoryTextBox", 100, 57, 180, 20, 1);
        this.resultGroupBox.Controls.Add(this.categoryTextBox);
        this.categoryTextBox.ReadOnly = true;

        // savings plan group box
        this.savingPlanGroupBox = createGroupBox("Savings Plan", 460, 10, 330, 190);
        this.Controls.Add(this.savingPlanGroupBox);

        // calculate savings plan button
        this.calculateSavingsButton = createButton("calculateSavingsPlanButton", "Calculate Savings", 560, 210, 130, 50, 1);
        this.Controls.Add(this.calculateSavingsButton);
        // add event handler for calculate button
        // this.calculateSavingsButton.Click += new System.EventHandler(this.calculateSavingsButtonHandler);

        // savings amount label and text box
        this.savingsAmountLabel = createLabel("savingsAmountLabel", "Savings Amount", 20, 30, 100, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.savingsAmountLabel);
        this.savingsAmountTextBox = createTextBox("savingsAmountTextBox", 130, 27, 180, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.savingsAmountTextBox);
        // monthly savings label and text box
        this.monthlyDepositLabel = createLabel("monthlyDepositLabel", "Monthly Deposit", 20, 60, 100, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.monthlyDepositLabel);
        this.monthlyDepositTextBox = createTextBox("monthlyDepositTextBox", 130, 57, 180, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.monthlyDepositTextBox);
        // period label and text box
        this.yearsLabel = createLabel("yearsLabel", "Period (years)", 20, 90, 100, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.yearsLabel);
        this.yearsTextBox = createTextBox("yearsTextBox", 130, 87, 180, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.yearsTextBox);
        // interest rate label and text box
        this.interestRateLabel = createLabel("interestRateLabel", "Interest Rate (%)", 20, 120, 100, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.interestRateLabel);
        this.interestRateTextBox = createTextBox("interestRateTextBox", 130, 117, 180, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.interestRateTextBox);
        // fee label and text box
        this.feesLabel = createLabel("feeLabel", "Fee (%)", 20, 150, 100, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.feesLabel);
        this.feesTextBox = createTextBox("feeTextBox", 130, 147, 180, 20, 1);
        this.savingPlanGroupBox.Controls.Add(this.feesTextBox);



        // savings result group box
        this.savingPlanResultsGroupBox = createGroupBox("Savings Plan Results", 460, 270, 330, 160);
        this.Controls.Add(this.savingPlanResultsGroupBox);

        // amount paid label and text box
        this.amountPaidLabel = createLabel("amountPaidLabel", "Amount Paid", 20, 30, 100, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.amountPaidLabel);
        this.amountPaidTextBox = createTextBox("amountPaidTextBox", 130, 27, 180, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.amountPaidTextBox);
        this.amountPaidTextBox.ReadOnly = true;
        // amount earned label and text box
        this.amountEarnedLabel = createLabel("amountEarnedLabel", "Amount Earned", 20, 60, 100, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.amountEarnedLabel);
        this.amountEarnedTextBox = createTextBox("amountEarnedTextBox", 130, 57, 180, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.amountEarnedTextBox);
        this.amountEarnedTextBox.ReadOnly = true;
        // final balance label and text box
        this.finalBalanceLabel = createLabel("finalBalanceLabel", "Final Balance", 20, 90, 100, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.finalBalanceLabel);
        this.finalBalanceTextBox = createTextBox("finalBalanceTextBox", 130, 87, 180, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.finalBalanceTextBox);
        this.finalBalanceTextBox.ReadOnly = true;
        // total fees label and text box
        this.totalFeesLabel = createLabel("totalFeesLabel", "Total Fees", 20, 120, 100, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.totalFeesLabel);
        this.totalFeesTextBox = createTextBox("totalFeesTextBox", 130, 117, 180, 20, 1);
        this.savingPlanResultsGroupBox.Controls.Add(this.totalFeesTextBox);
        this.totalFeesTextBox.ReadOnly = true;


        // the rest of the space goes to bmr calculator
        this.bmrGroupBox = createGroupBox("BMR Calculator", 10, 430, 780, 260);
        this.Controls.Add(this.bmrGroupBox);

        // calculate bmr button
        this.calculateBMRButton = createButton("calculateBMRButton", "Calculate BMR", 170, 370, 130, 50, 10);
        this.Controls.Add(this.calculateBMRButton);

    }

    // initialize bmi group box
    private System.Windows.Forms.GroupBox createGroupBox(string name, int x, int y, int width, int height)
    {
        System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
        groupBox.Location = new System.Drawing.Point(x, y);
        groupBox.Name = name;
        groupBox.Size = new System.Drawing.Size(width, height);
        groupBox.TabIndex = 0;
        groupBox.TabStop = false;
        groupBox.Text = name;
        return groupBox;
    }

    // initialize label
    private System.Windows.Forms.Label createLabel(string name, string text, int x, int y, int width, int height, int tabIndex)
    {
        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
        label.Location = new System.Drawing.Point(x, y);
        label.Name = name;
        label.Size = new System.Drawing.Size(width, height);
        label.TabIndex = tabIndex;
        label.Text = text;
        return label;
    }

    // initialize text box
    private System.Windows.Forms.TextBox createTextBox(string name, int x, int y, int width, int height, int tabIndex)
    {
        System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
        textBox.Location = new System.Drawing.Point(x, y);
        textBox.Name = name;
        textBox.Size = new System.Drawing.Size(width, height);
        textBox.TabIndex = tabIndex;
        return textBox;
    }

    // initialize radio button
    private System.Windows.Forms.RadioButton createRadioButton(string name, string text, int x, int y, int width, int height, int tabIndex)
    {
        System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton();
        radioButton.Location = new System.Drawing.Point(x, y);
        radioButton.Name = name;
        radioButton.Size = new System.Drawing.Size(width, height);
        radioButton.TabIndex = tabIndex;
        radioButton.TabStop = true;
        radioButton.Text = text;
        radioButton.UseVisualStyleBackColor = true;
        return radioButton;
    }

    // initialize button
    private System.Windows.Forms.Button createButton(string name, string text, int x, int y, int width, int height, int tabIndex)
    {
        System.Windows.Forms.Button button = new System.Windows.Forms.Button();
        button.Location = new System.Drawing.Point(x, y);
        button.Name = name;
        button.Size = new System.Drawing.Size(width, height);
        button.TabIndex = tabIndex;
        button.Text = text;
        return button;
    }

    // radio button event handler for imperial or metric
    private void unitRadioHandler(object sender, EventArgs e)
    {
        if (sender == this.imperialRadioButton)
        {
            this.heightLabel.Text = "Height (ft, in)";
            this.bmiGroupBox.Controls.Remove(this.metricHeightTextBox);
            this.bmiGroupBox.Controls.Add(this.imperialHeightFeetTextBox);
            this.bmiGroupBox.Controls.Add(this.imperialHeightInchesTextBox);
            this.weightLabel.Text = "Weight (lb)";
        }
        else if (sender == this.metricRadioButton)
        {
            this.heightLabel.Text = "Height (cm)";
            this.bmiGroupBox.Controls.Add(this.metricHeightTextBox);
            this.bmiGroupBox.Controls.Remove(this.imperialHeightFeetTextBox);
            this.bmiGroupBox.Controls.Remove(this.imperialHeightInchesTextBox);
            this.weightLabel.Text = "Weight (kg)";
        }
    }

    // calculate button event handler
    private void calculateButtonHandler(object sender, EventArgs e)
    {
      string[] name = this.nameTextBox.Text.Split(' ');
      if (name[0] == "")
      {
        // pop up a message box if the name is empty
        return;
      }
      this.resultGroupBox.Text = "Results for " + name[0];
    }

    // text box event handler for active/inactive button
    private void activateCalculateButtonHandler(object sender, EventArgs e)
    {
      // check if imperial or metric
      if (this.imperialRadioButton.Checked)
      {
        // check if all text boxes are filled
        if (this.nameTextBox.Text != "" && this.imperialHeightFeetTextBox.Text != "" && this.imperialHeightInchesTextBox.Text != "" && this.weightTextBox.Text != "")
        {
          this.calculateButton.Enabled = true;
        }
        else
        {
          this.calculateButton.Enabled = false;
        }
      }
      else if (this.metricRadioButton.Checked)
      {
        // check if all text boxes are filled
        if (this.nameTextBox.Text != "" && this.metricHeightTextBox.Text != "" && this.weightTextBox.Text != "")
        {
          this.calculateButton.Enabled = true;
        }
        else
        {
          this.calculateButton.Enabled = false;
        }
      }
    }

    // numeric value only event handler
    private void numericValueOnlyHandler(object sender, KeyPressEventArgs e)
    {
      // check if the key pressed is a number or a backspace or a decimal point with preceding number
      if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !(e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') == -1))
      {
        e.Handled = true;
      }
    }

}
