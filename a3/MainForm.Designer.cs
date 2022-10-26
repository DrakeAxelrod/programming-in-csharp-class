namespace a3;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Super Calculator by Drake Axelrod";

        // add a group box bmi calculator
        System.Windows.Forms.GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox1.Location = new System.Drawing.Point(15, 15);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(300, 140);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "BMI Calculator";
        this.Controls.Add(groupBox1);
        // add a label for name and an input box
        System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
        label1.Location = new System.Drawing.Point(20, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 20);
        label1.TabIndex = 0;
        label1.Text = "Name";
        groupBox1.Controls.Add(label1);
        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
        textBox1.Location = new System.Drawing.Point(120, 30);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(150, 20);
        textBox1.TabIndex = 1;
        groupBox1.Controls.Add(textBox1);
        // add a label for height and an input box
        System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
        label2.Location = new System.Drawing.Point(20, 60);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 20);
        label2.TabIndex = 0;
        label2.Text = "Height (cm)";
        groupBox1.Controls.Add(label2);
        System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
        textBox2.Location = new System.Drawing.Point(120, 60);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(150, 20);
        textBox2.TabIndex = 2;
        groupBox1.Controls.Add(textBox2);
        // add a label for weight and an input box
        System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
        label3.Location = new System.Drawing.Point(20, 90);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 20);
        label3.TabIndex = 0;
        label3.Text = "Weight (kg)";
        groupBox1.Controls.Add(label3);
        System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
        textBox3.Location = new System.Drawing.Point(120, 90);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(150, 20);
        textBox3.TabIndex = 3;
        groupBox1.Controls.Add(textBox3);

        // add a button under the group box
        System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
        button1.Location = new System.Drawing.Point(15, 160);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(300, 50);
        button1.TabIndex = 1;
        button1.Text = "Calculate BMI";
        button1.UseVisualStyleBackColor = true;
        // button1.Click += new System.EventHandler(this.button1_Click);
        this.Controls.Add(button1);


        // add group box for Unit (Metric or Imperial)
        System.Windows.Forms.GroupBox groupBox2 = new System.Windows.Forms.GroupBox();
        groupBox2.Location = new System.Drawing.Point(330, 15);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(150, 100);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Unit";
        this.Controls.Add(groupBox2);
        // add radio buttons for unit
        System.Windows.Forms.RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
        radioButton1.Location = new System.Drawing.Point(20, 30);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(120, 20);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "Metric (kg, cm)";
        radioButton1.UseVisualStyleBackColor = true;
        groupBox2.Controls.Add(radioButton1);
        System.Windows.Forms.RadioButton radioButton2 = new System.Windows.Forms.RadioButton();
        radioButton2.Location = new System.Drawing.Point(20, 60);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new System.Drawing.Size(120, 20);
        radioButton2.TabIndex = 1;
        radioButton2.TabStop = true;
        radioButton2.Text = "Imperial (lb, in)";
        radioButton2.UseVisualStyleBackColor = true;
        groupBox2.Controls.Add(radioButton2);

    }

}
