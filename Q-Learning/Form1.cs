using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int beta = 0;
        private int alpha = 0;
        private bool auto = true;
        
        private bool isInitialized = false;
        private bool randomActionTaken = false;

        private LoopFinderForm lfForm = new LoopFinderForm();

        private List<Tuple> tupleHistory = new List<Tuple>();

        public Form1()
        {
            InitializeComponent();
            
        }
        /*
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
        */
        public void DrawTable(object sender, System.EventArgs e)
        {
            if (!isInitialized)
            {
                isInitialized = true;
                Int32.TryParse(numStatesTextBox.Text, out numStates);
                Int32.TryParse(numActionsTextBox.Text, out numActions);

            }
            if (numActions > 0 && numStates > 0)
            {
                if (module == null)
                {
                    if (alpha > 0)
                    {
                        auto = false;
                    }
                    /*
                     * 
                     * vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                     * 
                     */
                    module = new QLearningModule(numStates, numActions, 250, auto, alpha, beta);
                    /*
                     * 
                     * ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                     * 
                     */
                }
                GenerateTable(numActions, numStates);
                GenerateCountTable(numActions, numStates);
            }
        }

        public void EnterCurrentState(object sender, System.EventArgs e)
        {
            randomActionTaken = false;
            int temp;
            if (Int32.TryParse(this.currentStateTextBox.Text, out temp))
            {
                this.bestActionTextBox.Text = module.BestAction(temp).ToString();
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
                        if (Int32.TryParse(this.bestActionTextBox.Text, out action))
                        {
                            module.LearnUtility(currentState, nextState, action, reward);

                            int temp = module.utilityTable.GetRowMaxColumn(currentState);
                            double val = module.utilityTable.GetValue(currentState,temp);

                            Tuple newTuple = new Tuple()
                            {
                                currentState = currentStateTextBox.Text,
                                action = bestActionTextBox.Text,
                                nextState = nextStateTextBox.Text,
                                reward = Int32.Parse(rewardGainedTextBox.Text),
                                Qval = module.utilityTable.GetValue(currentState, action),
                                Vval = val,

                            };
                            
                            if (randomActionTaken)
                            {
                                tupleHistory.Clear();
                            }

                            bool foundLoop = SearchForLoops(newTuple);

                            tupleHistory.Add(newTuple);
                            lfForm.AddRow(newTuple);

                            if (randomActionTaken)
                            {
                                lfForm.DenoteRandom();
                                randomActionTaken = false;
                            }

                            if (foundLoop)
                            {

                                int indexOfLoop = tupleHistory.IndexOf(newTuple);
                                int loopLength = tupleHistory.Count - indexOfLoop + 1;

                                lfForm.HighlightLoop(loopLength, randomActionTaken);
                                tupleHistory.Clear();
                                tupleHistory.Add(newTuple);
                                foundLoop = false;
                            }

                            tableLayoutPanel1.GetControlFromPosition(action, currentState).Text = module.utilityTable.data[numActions*currentState+action].ToString();

                            tableLayoutPanel2.GetControlFromPosition(action, currentState).Text = module.utilityUpdates.data[numActions * currentState + action].ToString();
                        
                            this.currentStateTextBox.Text = nextState.ToString();
                            // Reset best action so there's no confusion to press the button
                            this.bestActionTextBox.Text = "";
                            this.turnCounter.Text = module.GetNumberOfUpdates().ToString();
                            this.totalRewardLabel.Text = module.totalRewardGained.ToString();

                        }
                    }
                }
            }
        }

        public bool SearchForLoops(Tuple newTuple)
        {
            if (tupleHistory.Contains(newTuple))
            {
                return true;
            }
            return false;
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

        private void Export_Click(object sender, EventArgs e)
        {
            const string filename = "export.csv";
            var sb = new StringBuilder();
            for (var i = 0; i < numStates; i++)
            {
                for (var j = 0; j < numActions; j++)
                {
                    sb.AppendFormat("{0},", module.utilityTable.data[i*numActions + j]);
                }
                sb.Append("\r\n");
           }
           File.WriteAllText(filename, sb.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(this.textBox1.Text, out temp))
            {
               beta = temp;
            }

           }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(this.textBox2.Text, out temp))
            {
                alpha = temp;
            }

        }

        private void RandomActionButton_Click(object sender, EventArgs e)
        {
            randomActionTaken = true;
            var rand = new Random();
            this.bestActionTextBox.Text = rand.Next(0, numActions).ToString();

        }

        private void GenerateCountTable(int columnCount, int rowCount)
        {
            //Clear out the existing controls, we are generating a new table layout
            tableLayoutPanel2.Controls.Clear();

            //Clear out the existing row and column styles
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            tableLayoutPanel2.ColumnCount = columnCount;
            tableLayoutPanel2.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }

                    Label l = new Label();
                    //l.Margin = new Padding(1);

                    //l.Dock = DockStyle.Fill;
                    //l.TextAlign = ContentAlignment.MiddleCenter;
                    //l.AutoSize = false;

                    l.Text = module.utilityUpdates.GetValue(y, x).ToString();
                    //l.Text = module.utilityTable.data[y * columnCount + x].ToString();         //Finally, add the control to the correct location in the table
                    tableLayoutPanel2.Controls.Add(l, x, y);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void OpenLoopFinderButton_Click(object sender, EventArgs e)
        {
            lfForm.Show();
        }

    }
}
