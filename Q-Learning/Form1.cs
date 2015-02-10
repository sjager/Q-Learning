using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLearningAlgorithm;

namespace Q_Learning
{
    public partial class Form1 : Form
    {

        private QLearningModule module;
        private int numStates = 0;
        private int numActions = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void SaveNumStates(object sender, System.EventArgs e)
        {
            int temp;
            if (Int32.TryParse(this.numStatesTextBox.Text, out temp))
            {
                numStates = temp;
            }
        }

        public void SaveNumActions(object sender, System.EventArgs e)
        {
            int temp;
            if (Int32.TryParse(this.numActionsTextBox.Text, out temp))
            {
                numActions = temp;
            }
        }

        public void DrawTable(object sender, System.EventArgs e)
        {
            if (numActions > 0 && numStates > 0)
            {
                if (module == null)
                {
                    /*
                     * 
                     * vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                     * 
                     */
                    module = new QLearningModule(numStates, numActions, 250, true, .8, .8);
                    /*
                     * 
                     * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                     * 
                     */
                }
                GenerateTable(numActions, numStates);
            }
        }

        public void EnterCurrentState(object sender, System.EventArgs e)
        {
            int temp;
            if (Int32.TryParse(this.currentStateTextBox.Text, out temp))
            {
                this.bestActionLabel.Text = module.BestAction(temp).ToString();
            }
        }

        public void EnterRewardGained(object sender, System.EventArgs e)
        {
            int reward, currentState, nextState, action;
            if (Int32.TryParse(this.rewardGainedTextBox.Text, out reward))
            {
                if (Int32.TryParse(this.currentStateTextBox.Text, out currentState))
                {
                    if (Int32.TryParse(this.nextStateTextBox.Text, out nextState))
                    {
                        if (Int32.TryParse(this.bestActionLabel.Text, out action))
                        {
                            module.LearnUtility(currentState, nextState, action, reward);
                            GenerateTable(numActions, numStates);
                            this.currentStateTextBox.Text = nextState.ToString();
                        }
                    }
                }
            }
        }

        private void GenerateTable(int columnCount, int rowCount)
        {
           //Clear out the existing controls, we are generating a new table layout
           tableLayoutPanel1.Controls.Clear();

           //Clear out the existing row and column styles
           tableLayoutPanel1.ColumnStyles.Clear();
           tableLayoutPanel1.RowStyles.Clear();

           //Now we will generate the table, setting up the row and column counts first
           tableLayoutPanel1.ColumnCount = columnCount;
           tableLayoutPanel1.RowCount = rowCount;

           for (int x = 0; x < columnCount; x++)
           {
              //First add a column
              tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));

              for (int y = 0; y < rowCount; y++)
              {
                 //Next, add a row.  Only do this when once, when creating the first column
                 if (x == 0)
                 {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                 }

                 //Create the control, in this case we will add a button
                 Label l = new Label();
                 l.Text = module.utilityTable.data[y*columnCount + x].ToString();         //Finally, add the control to the correct location in the table
                 tableLayoutPanel1.Controls.Add(l, x, y);
              }
           }
        }

    }
}
