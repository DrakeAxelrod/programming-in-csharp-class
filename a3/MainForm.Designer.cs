namespace a3;

partial class MainForm
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  private BMICalculator bmiCalc = new BMICalculator();
  private SavingsPlan savingsPlan = new SavingsPlan();

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

  System.Windows.Forms.Label normalBMIRangeLabel;
  System.Windows.Forms.Label normalWeightRangeLabel;

  // bmr visual components
  private System.Windows.Forms.GroupBox bmrGroupBox;
  private System.Windows.Forms.GroupBox genderGroupBox;
  private System.Windows.Forms.GroupBox activityGroupBox;
  private System.Windows.Forms.Button calculateBMRButton;
  private System.Windows.Forms.RadioButton maleRadioButton;
  private System.Windows.Forms.RadioButton femaleRadioButton;

  private System.Windows.Forms.RadioButton sedentaryRadioButton;
  private System.Windows.Forms.RadioButton lightlyActiveRadioButton;
  private System.Windows.Forms.RadioButton moderatelyActiveRadioButton;
  private System.Windows.Forms.RadioButton activeRadioButton;
  private System.Windows.Forms.RadioButton veryActiveRadioButton;
  private System.Windows.Forms.RadioButton extraActiveRadioButton;
  private System.Windows.Forms.Label ageLabel;
  private System.Windows.Forms.TextBox ageTextBox;

  // bmr results components
  private System.Windows.Forms.ListBox bmrResultsBox;



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
    bmiCalc.setUnit(UnitType.Metric);
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

    // event handler for name text box
    this.nameTextBox.TextChanged += new System.EventHandler(
      delegate (object sender, EventArgs e)
      {
        bmiCalc.setName(this.nameTextBox.Text);
      }
    );

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
    this.calculateButton.Click += new System.EventHandler(this.calculateBMIButtonHandler);
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
    // add a label for category and an input box next to it
    this.categoryLabel = createLabel("categoryLabel", "Category", 20, 60, 80, 20, 1);
    this.resultGroupBox.Controls.Add(this.categoryLabel);
    this.categoryTextBox = createTextBox("categoryTextBox", 100, 57, 180, 20, 1);
    this.resultGroupBox.Controls.Add(this.categoryTextBox);
    this.categoryTextBox.ReadOnly = true;

    this.normalBMIRangeLabel = createLabel("normalRangeLabel", "the normal range for bmi is 18.5 to 25", 10, 100, 300, 20, 0);
    normalBMIRangeLabel.ForeColor = System.Drawing.Color.Green;
    this.resultGroupBox.Controls.Add(this.normalBMIRangeLabel);
    this.normalBMIRangeLabel.Visible = false;

    this.normalWeightRangeLabel = createLabel("lowerBoundLabel", "", 10, 120, 300, 20, 0);
    this.resultGroupBox.Controls.Add(this.normalWeightRangeLabel);
    this.normalBMIRangeLabel.Visible = false;

    // savings plan group box
    this.savingPlanGroupBox = createGroupBox("Savings Plan", 460, 10, 330, 190);
    this.Controls.Add(this.savingPlanGroupBox);

    // calculate savings plan button
    this.calculateSavingsButton = createButton("calculateSavingsPlanButton", "Calculate Savings", 560, 210, 130, 50, 1);
    this.Controls.Add(this.calculateSavingsButton);
    this.calculateSavingsButton.Enabled = false;
    // add event handler for calculate button
    this.calculateSavingsButton.Click += new System.EventHandler(this.calculateSavingsButtonHandler);

    // savings amount label and text box
    this.savingsAmountLabel = createLabel("savingsAmountLabel", "Savings Amount", 20, 30, 100, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.savingsAmountLabel);
    this.savingsAmountTextBox = createTextBox("savingsAmountTextBox", 130, 27, 180, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.savingsAmountTextBox);
    this.savingsAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activateSavingsButtonHandler);
    this.savingsAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);

    this.savingsAmountTextBox.Click += new System.EventHandler(delegate (object sender, EventArgs e)
    {
      if (this.savingsAmountTextBox.Text != "")
      {
        this.savingsPlan.setSavings(double.Parse(this.savingsAmountTextBox.Text));
      }
    });

    // monthly savings label and text box
    this.monthlyDepositLabel = createLabel("monthlyDepositLabel", "Monthly Deposit", 20, 60, 100, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.monthlyDepositLabel);
    this.monthlyDepositTextBox = createTextBox("monthlyDepositTextBox", 130, 57, 180, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.monthlyDepositTextBox);
    this.monthlyDepositTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activateSavingsButtonHandler);
    this.monthlyDepositTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
    this.monthlyDepositTextBox.Click += new System.EventHandler(delegate (object sender, EventArgs e)
    {
      if (this.monthlyDepositTextBox.Text != "")
      {
        this.savingsPlan.setMonthlyDeposit(double.Parse(this.monthlyDepositTextBox.Text));
      }
    });
    // period label and text box
    this.yearsLabel = createLabel("yearsLabel", "Period (years)", 20, 90, 100, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.yearsLabel);
    this.yearsTextBox = createTextBox("yearsTextBox", 130, 87, 180, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.yearsTextBox);
    this.yearsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activateSavingsButtonHandler);
    this.yearsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
    this.yearsTextBox.Click += new System.EventHandler(delegate (object sender, EventArgs e)
    {
      if (this.yearsTextBox.Text != "")
      {
        this.savingsPlan.setYears(int.Parse(this.yearsTextBox.Text));
      }
    });
    // interest rate label and text box
    this.interestRateLabel = createLabel("interestRateLabel", "Interest Rate (%)", 20, 120, 100, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.interestRateLabel);
    this.interestRateTextBox = createTextBox("interestRateTextBox", 130, 117, 180, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.interestRateTextBox);
    this.interestRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activateSavingsButtonHandler);
    this.interestRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
    this.interestRateTextBox.Click += new System.EventHandler(delegate (object sender, EventArgs e)
    {
      if (this.interestRateTextBox.Text != "")
      {
        this.savingsPlan.setInterestRate(double.Parse(this.interestRateTextBox.Text));
      }
    });
    // fee label and text box
    this.feesLabel = createLabel("feeLabel", "Fee (%)", 20, 150, 100, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.feesLabel);
    this.feesTextBox = createTextBox("feeTextBox", 130, 147, 180, 20, 1);
    this.savingPlanGroupBox.Controls.Add(this.feesTextBox);
    this.feesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activateSavingsButtonHandler);
    this.feesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
    this.feesTextBox.Click += new System.EventHandler(delegate (object sender, EventArgs e)
    {
      if (this.feesTextBox.Text != "")
      {
        this.savingsPlan.setFees(double.Parse(this.feesTextBox.Text));
      }
    });

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
    this.calculateBMRButton.Enabled = false;
    // add event handler for calculate button
    this.calculateBMRButton.Click += new System.EventHandler(this.calculateBmrButtonHandler);
    this.calculateBMRButton.Click += new System.EventHandler(this.activateCalculateButtonHandler);

    // gender group box
    this.genderGroupBox = createGroupBox("Gender", 10, 30, 100, 100, 1);
    this.bmrGroupBox.Controls.Add(this.genderGroupBox);

    // female radio button
    this.femaleRadioButton = createRadioButton("femaleRadioButton", "Female", 10, 30, 80, 20, 1);
    this.genderGroupBox.Controls.Add(this.femaleRadioButton);
    this.femaleRadioButton.Checked = true;
    // male radio button
    this.maleRadioButton = createRadioButton("maleRadioButton", "Male", 10, 60, 80, 20, 1);
    this.genderGroupBox.Controls.Add(this.maleRadioButton);

    // event handlers
    this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.genderRadioButtonHandler);
    this.maleRadioButton.CheckedChanged += new System.EventHandler(this.genderRadioButtonHandler);

    // age label and text box
    this.ageLabel = createLabel("ageLabel", "Age", 10, 140, 40, 20, 1);
    this.bmrGroupBox.Controls.Add(this.ageLabel);
    this.ageTextBox = createTextBox("ageTextBox", 50, 135, 60, 20, 1);

    // event handler for age text box
    this.ageTextBox.TextChanged += new System.EventHandler(this.activateCalculateButtonHandler);

    // add event handler for age text box
    this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBoxHandler);
    // add only numbers to age text box
    this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericValueOnlyHandler);
    this.bmrGroupBox.Controls.Add(this.ageTextBox);

    // weekly activity group box
    this.activityGroupBox = createGroupBox("Weekly Activity Level", 120, 30, 250, 200, 1);
    this.bmrGroupBox.Controls.Add(this.activityGroupBox);

    // sedentary radio button
    this.sedentaryRadioButton = createRadioButton("sedentaryRadioButton", "Sedentary (little or no exercise)", 10, 30, 230, 20, 1);
    this.activityGroupBox.Controls.Add(this.sedentaryRadioButton);
    this.sedentaryRadioButton.Checked = true;
    // lightly active radio button
    this.lightlyActiveRadioButton = createRadioButton("lightlyActiveRadioButton", "Lightly Active (1 to 3)", 10, 60, 230, 20, 1);
    this.activityGroupBox.Controls.Add(this.lightlyActiveRadioButton);
    // moderately active radio button
    this.moderatelyActiveRadioButton = createRadioButton("moderatelyActiveRadioButton", "Moderately Active (3 to 5)", 10, 90, 230, 20, 1);
    this.activityGroupBox.Controls.Add(this.moderatelyActiveRadioButton);
    // very active radio button
    this.veryActiveRadioButton = createRadioButton("veryActiveRadioButton", "Very Active (6 to 7)", 10, 120, 230, 20, 1);
    this.activityGroupBox.Controls.Add(this.veryActiveRadioButton);
    // extra active radio button
    this.extraActiveRadioButton = createRadioButton("extraActiveRadioButton", "Extra Active, hard exercise or job", 10, 150, 230, 20, 1);
    this.activityGroupBox.Controls.Add(this.extraActiveRadioButton);

    // add event handler for weekly activity radio buttons
    this.sedentaryRadioButton.CheckedChanged += new System.EventHandler(this.activityLevelRadioButtonHandler);
    this.lightlyActiveRadioButton.CheckedChanged += new System.EventHandler(this.activityLevelRadioButtonHandler);
    this.moderatelyActiveRadioButton.CheckedChanged += new System.EventHandler(this.activityLevelRadioButtonHandler);
    this.veryActiveRadioButton.CheckedChanged += new System.EventHandler(this.activityLevelRadioButtonHandler);
    this.extraActiveRadioButton.CheckedChanged += new System.EventHandler(this.activityLevelRadioButtonHandler);


    // result list box
    this.bmrResultsBox = createListBox("bmrResultListBox", 380, 34, 380, 200, 1);
    this.bmrGroupBox.Controls.Add(this.bmrResultsBox);
  }

  // initialize bmi group box
  private System.Windows.Forms.GroupBox createGroupBox(string name, int x, int y, int width, int height, int tabIndex = 0)
  {
    System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
    groupBox.Location = new System.Drawing.Point(x, y);
    groupBox.Name = name;
    groupBox.Size = new System.Drawing.Size(width, height);
    groupBox.TabIndex = tabIndex;
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

  // initialize list box
  private System.Windows.Forms.ListBox createListBox(string name, int x, int y, int width, int height, int tabIndex)
  {
    System.Windows.Forms.ListBox listBox = new System.Windows.Forms.ListBox();
    listBox.Location = new System.Drawing.Point(x, y);
    listBox.Name = name;
    listBox.Size = new System.Drawing.Size(width, height);
    listBox.TabIndex = tabIndex;
    return listBox;
  }

  // radio button event handler for imperial or metric
  private void unitRadioHandler(object sender, EventArgs e)
  {
    if (sender == this.imperialRadioButton)
    {
      bmiCalc.setUnit(UnitType.Imperial);
      this.heightLabel.Text = "Height (ft, in)";
      this.bmiGroupBox.Controls.Remove(this.metricHeightTextBox);
      this.bmiGroupBox.Controls.Add(this.imperialHeightFeetTextBox);
      this.bmiGroupBox.Controls.Add(this.imperialHeightInchesTextBox);
      // convert height to feet and inches if metric value is present
      if (this.metricHeightTextBox.Text != "")
      {
        double height = double.Parse(this.metricHeightTextBox.Text);
        double feet = Math.Floor(height / 30.48);
        double inches = Math.Round((height / 30.48 - feet) * 12);
        this.imperialHeightFeetTextBox.Text = feet.ToString();
        this.imperialHeightInchesTextBox.Text = inches.ToString();
      }
      this.weightLabel.Text = "Weight (lb)";
      // convert weight to pounds if imperial value is present
      if (this.weightTextBox.Text != "" && this.metricRadioButton.Checked)
      {
        double weight = double.Parse(this.weightTextBox.Text);
        double pounds = Math.Round(weight / 2.20462);
        this.weightTextBox.Text = pounds.ToString();
      }

    }
    else if (sender == this.metricRadioButton)
    {
      bmiCalc.setUnit(UnitType.Metric);
      this.heightLabel.Text = "Height (cm)";
      this.bmiGroupBox.Controls.Add(this.metricHeightTextBox);
      this.bmiGroupBox.Controls.Remove(this.imperialHeightFeetTextBox);
      this.bmiGroupBox.Controls.Remove(this.imperialHeightInchesTextBox);
      // convert height to centimeters if imperial value is present
      if (this.imperialHeightFeetTextBox.Text != "" && this.imperialHeightInchesTextBox.Text != "")
      {
        double feet = double.Parse(this.imperialHeightFeetTextBox.Text);
        double inches = double.Parse(this.imperialHeightInchesTextBox.Text);
        double height = Math.Round((feet * 12 + inches) * 2.54);
        this.metricHeightTextBox.Text = height.ToString();
      }
      this.weightLabel.Text = "Weight (kg)";
      // convert weight to kilograms if imperial value is present
      if (this.weightTextBox.Text != "" && this.imperialRadioButton.Checked)
      {
        double weight = double.Parse(this.weightTextBox.Text);
        double kilograms = Math.Round(weight * 2.20462);
        this.weightTextBox.Text = kilograms.ToString();
      }
    }
  }

  // calculate button event handler
  private void calculateBMIButtonHandler(object sender, EventArgs e)
  {
    this.bmiCalc.setName(this.nameTextBox.Text.Split(' ')[0]);
    this.resultGroupBox.Text = "Results for " + bmiCalc.getName();
    if (this.imperialRadioButton.Checked)
    {
      // imperial
      int feet = int.Parse(this.imperialHeightFeetTextBox.Text);
      int inches = int.Parse(this.imperialHeightInchesTextBox.Text);
      bmiCalc.setHeight(feet, inches);
      bmiCalc.setWeight(double.Parse(this.weightTextBox.Text));
    }
    else if (this.metricRadioButton.Checked)
    {
      // metric
      bmiCalc.setHeight(double.Parse(this.metricHeightTextBox.Text));
      bmiCalc.setWeight(double.Parse(this.weightTextBox.Text));
    }
    // calculate bmi
    double bmi = bmiCalc.CalculateBMI();
    // display bmi in a pop up message box
    string category = bmiCalc.BmiWeightCategory();
    this.bmiTextBox.Text = bmi.ToString("0.00000");
    this.categoryTextBox.Text = category;

    string weightMsg = "";
    Dictionary<string, string> weightRange = bmiCalc.NormalWeight();
    if (this.bmiCalc.getUnit() == UnitType.Imperial)
    {
      weightMsg = "Normal weight range is " + weightRange["min"] + " to " + weightRange["max"] + " lb";
    }
    else
    {
      weightMsg = "Normal weight range is " + weightRange["min"] + " to " + weightRange["max"] + " kg";
    }
    // add upper and lower bounds for normal weight range
    this.normalWeightRangeLabel.Text = weightMsg;
    this.normalBMIRangeLabel.Visible = true;
    this.normalWeightRangeLabel.Visible = true;
  }

  // text box event handler for active/inactive button
  private void activateCalculateButtonHandler(object sender, EventArgs e)
  {
    // activate bmi calculate button if name, height, and weight are present
    if (this.weightTextBox.Text != "")
    {
      if (this.imperialRadioButton.Checked)
      {
        if (this.imperialHeightFeetTextBox.Text != "" && this.imperialHeightInchesTextBox.Text != "")
        {
          this.calculateButton.Enabled = true;
        }
      }
      else if (this.metricRadioButton.Checked)
      {
        if (this.metricHeightTextBox.Text != "")
        {
          this.calculateButton.Enabled = true;
        }
      }
    }
    // activate bmr calculate button if name, age, height, and weight are present
    if (this.weightTextBox.Text != "" && this.ageTextBox.Text != "")
    {
      if (this.imperialRadioButton.Checked)
      {
        if (this.imperialHeightFeetTextBox.Text != "" && this.imperialHeightInchesTextBox.Text != "")
        {
          this.calculateBMRButton.Enabled = true;
        }
      }
      else if (this.metricRadioButton.Checked)
      {
        if (this.metricHeightTextBox.Text != "")
        {
          this.calculateBMRButton.Enabled = true;
        }
      }
    }
  }

  // activate calculate savings button if savings, monthly, period, interest, and fees are present
  private void activateSavingsButtonHandler(object sender, EventArgs e)
  {
    if (this.savingsAmountTextBox.Text != "" && this.monthlyDepositTextBox.Text != "" && this.yearsTextBox.Text != "" && this.interestRateTextBox.Text != "" && this.feesTextBox.Text != "")
    {
      this.calculateSavingsButton.Enabled = true;
    }
    else
    {
      this.calculateSavingsButton.Enabled = false;
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

  // activate bmr button event handler
  private void calculateBmrButtonHandler(object sender, EventArgs e)
  {
    // get height and weight from text boxes
    double height = 0;
    double weight = 0;
    if (this.imperialRadioButton.Checked)
    {
      height = Convert.ToDouble(this.imperialHeightFeetTextBox.Text) * 12 + Convert.ToDouble(this.imperialHeightInchesTextBox.Text);
      weight = Convert.ToDouble(this.weightTextBox.Text);
    }
    else if (this.metricRadioButton.Checked)
    {
      height = Convert.ToDouble(this.metricHeightTextBox.Text);
      weight = Convert.ToDouble(this.weightTextBox.Text);
    }

    // get age from text box
    double age = Convert.ToDouble(this.ageTextBox.Text);
    // get activity level from list box
    ActivityLevel activityLevel = bmiCalc.getActivityLevel();
    // clear bmr result list box
    this.bmrResultsBox.Items.Clear();
    double bmr = bmiCalc.CalculateBMR();
    this.bmrResultsBox.Items.Add("BMR Results for " + bmiCalc.getName());
    this.bmrResultsBox.Items.Add("");
    this.bmrResultsBox.Items.Add("Your BMR (Calories/day) is " + bmr.ToString("0.00"));
    double factor = 0;
    switch (activityLevel)
    {
      case ActivityLevel.Sedentary:
        factor = 1.2;
        break;
      case ActivityLevel.LightlyActive:
        factor = 1.375;
        break;
      case ActivityLevel.ModeratelyActive:
        factor = 1.55;
        break;
      case ActivityLevel.VeryActive:
        factor = 1.725;
        break;
      case ActivityLevel.ExtraActive:
        factor = 1.9;
        break;
    }
    double tdee = bmr * factor;
    if (bmiCalc.getUnit() == UnitType.Imperial)
    {

      this.bmrResultsBox.Items.Add("Calories needed to maintain weight is " + tdee.ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to lose 1 lb per week is " + (tdee - 500).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to lose 2 lb per week is " + (tdee - 1000).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to gain 1 lb per week is " + (tdee + 500).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to gain 2 lb per week is " + (tdee + 1000).ToString("0.00"));
      this.bmrResultsBox.Items.Add("");
      this.bmrResultsBox.Items.Add("Losing more than 1000 calories per day is not recommended.");
    }
    else
    {
      this.bmrResultsBox.Items.Add("Calories needed to maintain weight is " + tdee.ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to lose 0.5 kg per week is " + (tdee - 500).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to lose 1 kg per week is " + (tdee - 1000).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to gain 0.5 kg per week is " + (tdee + 500).ToString("0.00"));
      this.bmrResultsBox.Items.Add("Calories needed to gain 1 kg per week is " + (tdee + 1000).ToString("0.00"));
      this.bmrResultsBox.Items.Add("");
      this.bmrResultsBox.Items.Add("Losing more than 1000 calories per day is not recommended.");
    }
  }

  // calculate savings button event handler
  private void calculateSavingsButtonHandler(object sender, EventArgs e)
  {
    this.amountPaidTextBox.Text = this.savingsPlan.CalculateAmountPaid().ToString("0.00");
    this.amountEarnedTextBox.Text = this.savingsPlan.CalculateAmountEarned().ToString("0.00");
    this.finalBalanceTextBox.Text = this.savingsPlan.CalculateFinalBalance().ToString("0.00");
    this.totalFeesTextBox.Text = this.savingsPlan.CalculateTotalFees().ToString("0.00");
  }

  // activity level radio button event handler
  private void activityLevelRadioButtonHandler(object sender, EventArgs e)
  {
    if (sender == this.sedentaryRadioButton)
    {
      this.bmiCalc.setActivityLevel(ActivityLevel.Sedentary);
    }
    else if (sender == this.lightlyActiveRadioButton)
    {
      this.bmiCalc.setActivityLevel(ActivityLevel.LightlyActive);
    }
    else if (sender == this.moderatelyActiveRadioButton)
    {
      this.bmiCalc.setActivityLevel(ActivityLevel.ModeratelyActive);
    }
    else if (sender == this.veryActiveRadioButton)
    {
      this.bmiCalc.setActivityLevel(ActivityLevel.VeryActive);
    }
    else if (sender == this.extraActiveRadioButton)
    {
      this.bmiCalc.setActivityLevel(ActivityLevel.ExtraActive);
    }
  }

  // gender radio button event handler
  private void genderRadioButtonHandler(object sender, EventArgs e)
  {
    if (sender == this.maleRadioButton)
    {
      this.bmiCalc.setGender(Gender.Male);
    }
    else
    {
      this.bmiCalc.setGender(Gender.Female);
    }
  }

  // age text box event handler
  private void ageTextBoxHandler(object sender, EventArgs e)
  {
    if (this.ageTextBox.Text != "")
    {
      bmiCalc.setAge(int.Parse(this.ageTextBox.Text));
    }
  }
}
