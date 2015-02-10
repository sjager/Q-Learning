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
            this.bestActionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numStatesTextBox
            // 
            this.numStatesTextBox.Location = new System.Drawing.Point(754, 21);
            this.numStatesTextBox.Name = "numStatesTextBox";
            this.numStatesTextBox.Size = new System.Drawing.Size(32, 20);
            this.numStatesTextBox.TabIndex = 0;
            // 
            // numStatesButton
            // 
            this.numStatesButton.Location = new System.Drawing.Point(823, 21);
            this.numStatesButton.Name = "numStatesButton";
            this.numStatesButton.Size = new System.Drawing.Size(119, 19);
            this.numStatesButton.TabIndex = 1;
            this.numStatesButton.Text = "numStatesButton";
            this.numStatesButton.UseVisualStyleBackColor = true;
            this.numStatesButton.Click += new System.EventHandler(this.SaveNumStates);
            // 
            // numActionsTextBox
            // 
            this.numActionsTextBox.Location = new System.Drawing.Point(754, 48);
            this.numActionsTextBox.Name = "numActionsTextBox";
            this.numActionsTextBox.Size = new System.Drawing.Size(32, 20);
            this.numActionsTextBox.TabIndex = 2;
            // 
            // numActionsButton
            // 
            this.numActionsButton.Location = new System.Drawing.Point(823, 47);
            this.numActionsButton.Name = "numActionsButton";
            this.numActionsButton.Size = new System.Drawing.Size(118, 21);
            this.numActionsButton.TabIndex = 3;
            this.numActionsButton.Text = "numActionsButton";
            this.numActionsButton.UseVisualStyleBackColor = true;
            this.numActionsButton.Click += new System.EventHandler(this.SaveNumActions);
            // 
            // drawTableButton
            // 
            this.drawTableButton.Location = new System.Drawing.Point(870, 75);
            this.drawTableButton.Name = "drawTableButton";
            this.drawTableButton.Size = new System.Drawing.Size(71, 23);
            this.drawTableButton.TabIndex = 4;
            this.drawTableButton.Text = "drawTableButton";
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
            this.currentStateButton.Location = new System.Drawing.Point(335, 8);
            this.currentStateButton.Name = "currentStateButton";
            this.currentStateButton.Size = new System.Drawing.Size(147, 28);
            this.currentStateButton.TabIndex = 6;
            this.currentStateButton.Text = "currentStateButton";
            this.currentStateButton.UseVisualStyleBackColor = true;
            this.currentStateButton.Click += new System.EventHandler(this.EnterCurrentState);
            // 
            // rewardGainedButton
            // 
            this.rewardGainedButton.Location = new System.Drawing.Point(335, 44);
            this.rewardGainedButton.Name = "rewardGainedButton";
            this.rewardGainedButton.Size = new System.Drawing.Size(147, 27);
            this.rewardGainedButton.TabIndex = 7;
            this.rewardGainedButton.Text = "rewardGainedButton";
            this.rewardGainedButton.UseVisualStyleBackColor = true;
            this.rewardGainedButton.Click += new System.EventHandler(this.EnterRewardGained);
            // 
            // currentStateTextBox
            // 
            this.currentStateTextBox.Location = new System.Drawing.Point(186, 13);
            this.currentStateTextBox.Name = "currentStateTextBox";
            this.currentStateTextBox.Size = new System.Drawing.Size(134, 20);
            this.currentStateTextBox.TabIndex = 8;
            // 
            // rewardGainedTextBox
            // 
            this.rewardGainedTextBox.Location = new System.Drawing.Point(186, 48);
            this.rewardGainedTextBox.Name = "rewardGainedTextBox";
            this.rewardGainedTextBox.Size = new System.Drawing.Size(133, 20);
            this.rewardGainedTextBox.TabIndex = 9;
            // 
            // nextStateTextBox
            // 
            this.nextStateTextBox.Location = new System.Drawing.Point(39, 48);
            this.nextStateTextBox.Name = "nextStateTextBox";
            this.nextStateTextBox.Size = new System.Drawing.Size(141, 20);
            this.nextStateTextBox.TabIndex = 10;
            // 
            // bestActionLabel
            // 
            this.bestActionLabel.AutoSize = true;
            this.bestActionLabel.Location = new System.Drawing.Point(515, 16);
            this.bestActionLabel.Name = "bestActionLabel";
            this.bestActionLabel.Size = new System.Drawing.Size(13, 13);
            this.bestActionLabel.TabIndex = 12;
            this.bestActionLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 565);
            this.Controls.Add(this.bestActionLabel);
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
        private System.Windows.Forms.Label bestActionLabel;

        
    }
}

