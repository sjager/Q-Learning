using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Learning
{
    public partial class LoopFinderForm : Form
    {
        public Color currentColor = Color.White;

        public LoopFinderForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            populateColumns();
            
        }

        private void populateColumns()
        {

            var stateCol = new DataGridViewTextBoxColumn();
            var actionCol = new DataGridViewTextBoxColumn();
            var nextStateCol = new DataGridViewTextBoxColumn();

            stateCol.HeaderText = "State";
            stateCol.Name = "StateColumn";

            actionCol.HeaderText = "Action";
            actionCol.Name = "ActionColumn";

            nextStateCol.HeaderText = "NextState";
            nextStateCol.Name = "NextStateColumn";

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stateCol, actionCol, nextStateCol });

        }

        public void AddRow(Tuple tuple)
        {
            dataGridView1.Rows.Add(tuple.currentState, tuple.action, tuple.nextState);
        }

        public void HighlightLoop(int completeLoopLength, bool randomActionTaken)
        {
            for (int i = (dataGridView1.Rows.Count - completeLoopLength); i < dataGridView1.Rows.Count-1; i++ )
            {
                if(dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.LightBlue)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                
            }
        }

        public void DenoteRandom()
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
