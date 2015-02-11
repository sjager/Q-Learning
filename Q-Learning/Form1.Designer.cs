using System.Security.AccessControl;

namespace Q_Learning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numStatesTextBox = new System.Windows.Forms.TextBox();
            this.numStatesButton = new System.Windows.Forms.Button();
            this.numActionsTextBox = new System.Windows.Forms.TextBox();
            this.numActionsButton = new System.Windows.Forms.Button();
            this.drawTableButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentStateButton = new System.Windows.Forms.Button();
            this.rewardGainedButton = new System.Windows.Forms.Button();
            this.currentStateTextBox = new System.Windows.Forms.TextBox();
            this.rewardGainedTextBox = new System.Windows.Forms.TextBox();
            this.nextStateTextBox = new System.Windows.Forms.TextBox();
            this.bestActionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numStatesTextBox
            // 
            this.numStatesTextBox.Location = new System.Drawing.Point(55, 13);
            this.numStatesTextBox.Name = "numStatesTextBox";
            this.numStatesTextBox.Size = new System.Drawing.Size(32, 20);
            this.numStatesTextBox.TabIndex = 0;
            // 
            // numStatesButton
            // 
            this.numStatesButton.Location = new System.Drawing.Point(93, 14);
            this.numStatesButton.Name = "numStatesButton";
            this.numStatesButton.Size = new System.Drawing.Size(119, 19);
            this.numStatesButton.TabIndex = 1;
            this.numStatesButton.Text = "Number of States";
            this.numStatesButton.UseVisualStyleBackColor = true;
            this.numStatesButton.Click += new System.EventHandler(this.SaveNumStates);
            // 
            // numActionsTextBox
            // 
            this.numActionsTextBox.Location = new System.Drawing.Point(55, 40);
            this.numActionsTextBox.Name = "numActionsTextBox";
            this.numActionsTextBox.Size = new System.Drawing.Size(32, 20);
            this.numActionsTextBox.TabIndex = 2;
            // 
            // numActionsButton
            // 
            this.numActionsButton.Location = new System.Drawing.Point(93, 40);
            this.numActionsButton.Name = "numActionsButton";
            this.numActionsButton.Size = new System.Drawing.Size(118, 21);
            this.numActionsButton.TabIndex = 3;
            this.numActionsButton.Text = "Number of Actions";
            this.numActionsButton.UseVisualStyleBackColor = true;
            this.numActionsButton.Click += new System.EventHandler(this.SaveNumActions);
            // 
            // drawTableButton
            // 
            this.drawTableButton.Location = new System.Drawing.Point(140, 68);
            this.drawTableButton.Name = "drawTableButton";
            this.drawTableButton.Size = new System.Drawing.Size(71, 23);
            this.drawTableButton.TabIndex = 4;
            this.drawTableButton.Text = "Draw Table";
            this.drawTableButton.UseVisualStyleBackColor = true;
            this.drawTableButton.Click += new System.EventHandler(this.DrawTable);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 381);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // currentStateButton
            // 
            this.currentStateButton.Location = new System.Drawing.Point(700, 25);
            this.currentStateButton.Name = "currentStateButton";
            this.currentStateButton.Size = new System.Drawing.Size(147, 28);
            this.currentStateButton.TabIndex = 6;
            this.currentStateButton.Text = "Find Best Action";
            this.currentStateButton.UseVisualStyleBackColor = true;
            this.currentStateButton.Click += new System.EventHandler(this.EnterCurrentState);
            // 
            // rewardGainedButton
            // 
            this.rewardGainedButton.Location = new System.Drawing.Point(803, 79);
            this.rewardGainedButton.Name = "rewardGainedButton";
            this.rewardGainedButton.Size = new System.Drawing.Size(147, 27);
            this.rewardGainedButton.TabIndex = 7;
            this.rewardGainedButton.Text = "Enter Data";
            this.rewardGainedButton.UseVisualStyleBackColor = true;
            this.rewardGainedButton.Click += new System.EventHandler(this.EnterRewardGained);
            // 
            // currentStateTextBox
            // 
            this.currentStateTextBox.Location = new System.Drawing.Point(639, 30);
            this.currentStateTextBox.Name = "currentStateTextBox";
            this.currentStateTextBox.Size = new System.Drawing.Size(46, 20);
            this.currentStateTextBox.TabIndex = 8;
            // 
            // rewardGainedTextBox
            // 
            this.rewardGainedTextBox.Location = new System.Drawing.Point(700, 83);
            this.rewardGainedTextBox.Name = "rewardGainedTextBox";
            this.rewardGainedTextBox.Size = new System.Drawing.Size(75, 20);
            this.rewardGainedTextBox.TabIndex = 9;
            // 
            // nextStateTextBox
            // 
            this.nextStateTextBox.Location = new System.Drawing.Point(630, 83);
            this.nextStateTextBox.Name = "nextStateTextBox";
            this.nextStateTextBox.Size = new System.Drawing.Size(45, 20);
            this.nextStateTextBox.TabIndex = 10;
            // 
            // bestActionTextBox
            // 
            this.bestActionTextBox.Location = new System.Drawing.Point(880, 33);
            this.bestActionTextBox.Name = "bestActionTextBox";
            this.bestActionTextBox.Size = new System.Drawing.Size(13, 20);
            this.bestActionTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Step 1: Enter current state, find action to take";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Step 2: Enter resulting state and reward, enter into table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Best Action";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resulting State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Reward";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Beta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit beta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Alpha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Submit Alpha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 20);
            this.textBox2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 565);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestActionTextBox);
            this.Controls.Add(this.nextStateTextBox);
            this.Controls.Add(this.rewardGainedTextBox);
            this.Controls.Add(this.currentStateTextBox);
            this.Controls.Add(this.rewardGainedButton);
            this.Controls.Add(this.currentStateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.drawTableButton);
            this.Controls.Add(this.numActionsButton);
            this.Controls.Add(this.numActionsTextBox);
            this.Controls.Add(this.numStatesButton);
            this.Controls.Add(this.numStatesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numStatesTextBox;
        private System.Windows.Forms.Button numStatesButton;
        private System.Windows.Forms.TextBox numActionsTextBox;
        private System.Windows.Forms.Button numActionsButton;
        private System.Windows.Forms.Button drawTableButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button currentStateButton;
        private System.Windows.Forms.Button rewardGainedButton;
        private System.Windows.Forms.TextBox currentStateTextBox;
        private System.Windows.Forms.TextBox rewardGainedTextBox;
        private System.Windows.Forms.TextBox nextStateTextBox;
        private System.Windows.Forms.TextBox bestActionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;

        
    }
}

