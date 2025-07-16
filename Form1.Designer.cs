namespace SERA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaInterioaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateInterioaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaExterioaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umiditateExterioaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hUMDataSet = new SERA.HUMDataSet();
            this.tableTableAdapter = new SERA.HUMDataSetTableAdapters.TableTableAdapter();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(59, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(59, 466);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 62);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.temperaturaInterioaraDataGridViewTextBoxColumn,
            this.umiditateInterioaraDataGridViewTextBoxColumn,
            this.temperaturaExterioaraDataGridViewTextBoxColumn,
            this.umiditateExterioaraDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(59, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(808, 141);
            this.dataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperaturaInterioaraDataGridViewTextBoxColumn
            // 
            this.temperaturaInterioaraDataGridViewTextBoxColumn.DataPropertyName = "Temperatura interioara";
            this.temperaturaInterioaraDataGridViewTextBoxColumn.HeaderText = "Temperatura interioara";
            this.temperaturaInterioaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperaturaInterioaraDataGridViewTextBoxColumn.Name = "temperaturaInterioaraDataGridViewTextBoxColumn";
            this.temperaturaInterioaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // umiditateInterioaraDataGridViewTextBoxColumn
            // 
            this.umiditateInterioaraDataGridViewTextBoxColumn.DataPropertyName = "Umiditate interioara";
            this.umiditateInterioaraDataGridViewTextBoxColumn.HeaderText = "Umiditate interioara";
            this.umiditateInterioaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umiditateInterioaraDataGridViewTextBoxColumn.Name = "umiditateInterioaraDataGridViewTextBoxColumn";
            this.umiditateInterioaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperaturaExterioaraDataGridViewTextBoxColumn
            // 
            this.temperaturaExterioaraDataGridViewTextBoxColumn.DataPropertyName = "Temperatura exterioara";
            this.temperaturaExterioaraDataGridViewTextBoxColumn.HeaderText = "Temperatura exterioara";
            this.temperaturaExterioaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperaturaExterioaraDataGridViewTextBoxColumn.Name = "temperaturaExterioaraDataGridViewTextBoxColumn";
            this.temperaturaExterioaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // umiditateExterioaraDataGridViewTextBoxColumn
            // 
            this.umiditateExterioaraDataGridViewTextBoxColumn.DataPropertyName = "Umiditate exterioara";
            this.umiditateExterioaraDataGridViewTextBoxColumn.HeaderText = "Umiditate exterioara";
            this.umiditateExterioaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umiditateExterioaraDataGridViewTextBoxColumn.Name = "umiditateExterioaraDataGridViewTextBoxColumn";
            this.umiditateExterioaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hUMDataSet;
            // 
            // hUMDataSet
            // 
            this.hUMDataSet.DataSetName = "HUMDataSet";
            this.hUMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(389, 258);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Navy;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura interioara";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series2.Legend = "Legend1";
            series2.Name = "Temperatura exterioara";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Umiditate interioara";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Umiditate exterioara";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(593, 333);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 621);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView dataGridView;
        private HUMDataSet hUMDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private HUMDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaInterioaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateInterioaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaExterioaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umiditateExterioaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.IO.Ports.SerialPort serialPort;
    }
}

