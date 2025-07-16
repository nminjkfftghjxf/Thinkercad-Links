using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //serialPort.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hUMDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.hUMDataSet.Table);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Serial.println("24.5,23.8,55.0,58.1");
                /*
                string data = serialPort.ReadLine().Trim();

                string[] values = data.Split(',');

                if (values.Length == 4)
                {
                    
                    float ti = float.Parse(values[0]);
                    float te = float.Parse(values[1]);
                    float hi = float.Parse(values[2]);
                    float he = float.Parse(values[3]);

                   
                    DataRow newRow = hUMDataSet.Table.NewRow();
                    newRow["Temperatura interioara"] = ti;
                    newRow["Temperatura exterioara"] = te;
                    newRow["Umiditate interioara"] = hi;
                    newRow["Umiditate exterioara"] = he;
                    //newRow["DataTimp"] = DateTime.Now; 

                    hUMDataSet.Table.Rows.Add(newRow);

                    
                    chart.DataSource = hUMDataSet.Table;
                    chart.DataBind();
                }
                else
                {
                    MessageBox.Show("Eroare la Arduino?!");
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data: " + ex.Message);
            }
                
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {

                chart.Series["Temperatura interioara"].YValueMembers = "Temperatura interioara";

                chart.Series["Temperatura exterioara"].YValueMembers = "Temperatura exterioara";

                chart.Series["Umiditate interioara"].YValueMembers = "Umiditate interioara";

                chart.Series["Umiditate exterioara"].YValueMembers = "Umiditate exterioara";

                chart.DataSource = hUMDataSet.Table;
                chart.DataBind();

                tableTableAdapter.Update(hUMDataSet.Table);

                tableBindingSource.EndEdit();
            }
            catch (Exception ex) 
            {
                
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
