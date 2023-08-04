namespace WindowsFormsApp1
{
    partial class Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.XMinLabel = new System.Windows.Forms.Label();
            this.XMinTextBox = new System.Windows.Forms.TextBox();
            this.XMaxLabel = new System.Windows.Forms.Label();
            this.XMaximumTextBox = new System.Windows.Forms.TextBox();
            this.SlopeLabel = new System.Windows.Forms.Label();
            this.SlopeTextBox = new System.Windows.Forms.TextBox();
            this.InterceptLabel = new System.Windows.Forms.Label();
            this.InterceptTextBox = new System.Windows.Forms.TextBox();
            this.GraphButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabelChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(13, 13);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(13, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(13, 57);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(13, 74);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputTextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(119, 28);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Title = "X ";
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "Y";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(407, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(381, 362);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // XMinLabel
            // 
            this.XMinLabel.AutoSize = true;
            this.XMinLabel.Location = new System.Drawing.Point(334, 34);
            this.XMinLabel.Name = "XMinLabel";
            this.XMinLabel.Size = new System.Drawing.Size(58, 13);
            this.XMinLabel.TabIndex = 6;
            this.XMinLabel.Text = "X Minimum";
            // 
            // XMinTextBox
            // 
            this.XMinTextBox.Location = new System.Drawing.Point(334, 50);
            this.XMinTextBox.Name = "XMinTextBox";
            this.XMinTextBox.Size = new System.Drawing.Size(58, 20);
            this.XMinTextBox.TabIndex = 7;
            this.XMinTextBox.Text = "-5";
            // 
            // XMaxLabel
            // 
            this.XMaxLabel.AutoSize = true;
            this.XMaxLabel.Location = new System.Drawing.Point(334, 78);
            this.XMaxLabel.Name = "XMaxLabel";
            this.XMaxLabel.Size = new System.Drawing.Size(61, 13);
            this.XMaxLabel.TabIndex = 8;
            this.XMaxLabel.Text = "X Maximum";
            // 
            // XMaximumTextBox
            // 
            this.XMaximumTextBox.Location = new System.Drawing.Point(334, 94);
            this.XMaximumTextBox.Name = "XMaximumTextBox";
            this.XMaximumTextBox.Size = new System.Drawing.Size(58, 20);
            this.XMaximumTextBox.TabIndex = 9;
            this.XMaximumTextBox.Text = "5";
            // 
            // SlopeLabel
            // 
            this.SlopeLabel.AutoSize = true;
            this.SlopeLabel.Location = new System.Drawing.Point(334, 122);
            this.SlopeLabel.Name = "SlopeLabel";
            this.SlopeLabel.Size = new System.Drawing.Size(34, 13);
            this.SlopeLabel.TabIndex = 10;
            this.SlopeLabel.Text = "Slope";
            // 
            // SlopeTextBox
            // 
            this.SlopeTextBox.Location = new System.Drawing.Point(334, 138);
            this.SlopeTextBox.Name = "SlopeTextBox";
            this.SlopeTextBox.Size = new System.Drawing.Size(58, 20);
            this.SlopeTextBox.TabIndex = 11;
            // 
            // InterceptLabel
            // 
            this.InterceptLabel.AutoSize = true;
            this.InterceptLabel.Location = new System.Drawing.Point(331, 166);
            this.InterceptLabel.Name = "InterceptLabel";
            this.InterceptLabel.Size = new System.Drawing.Size(49, 13);
            this.InterceptLabel.TabIndex = 12;
            this.InterceptLabel.Text = "Intercept";
            // 
            // InterceptTextBox
            // 
            this.InterceptTextBox.Location = new System.Drawing.Point(334, 182);
            this.InterceptTextBox.Name = "InterceptTextBox";
            this.InterceptTextBox.Size = new System.Drawing.Size(58, 20);
            this.InterceptTextBox.TabIndex = 13;
            // 
            // GraphButton
            // 
            this.GraphButton.Location = new System.Drawing.Point(326, 208);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(75, 23);
            this.GraphButton.TabIndex = 14;
            this.GraphButton.Text = "Graph";
            this.GraphButton.UseVisualStyleBackColor = true;
            this.GraphButton.Click += new System.EventHandler(this.GraphButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(326, 238);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 101);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 16;
            this.ErrorLabel.UseMnemonic = false;
            // 
            // ErrorLabelChart
            // 
            this.ErrorLabelChart.AutoSize = true;
            this.ErrorLabelChart.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelChart.Location = new System.Drawing.Point(334, 9);
            this.ErrorLabelChart.Name = "ErrorLabelChart";
            this.ErrorLabelChart.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelChart.TabIndex = 17;
            this.ErrorLabelChart.UseMnemonic = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.ErrorLabelChart);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GraphButton);
            this.Controls.Add(this.InterceptTextBox);
            this.Controls.Add(this.InterceptLabel);
            this.Controls.Add(this.SlopeTextBox);
            this.Controls.Add(this.SlopeLabel);
            this.Controls.Add(this.XMaximumTextBox);
            this.Controls.Add(this.XMaxLabel);
            this.Controls.Add(this.XMinTextBox);
            this.Controls.Add(this.XMinLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.MinimumSize = new System.Drawing.Size(816, 457);
            this.Name = "Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label XMinLabel;
        private System.Windows.Forms.TextBox XMinTextBox;
        private System.Windows.Forms.Label XMaxLabel;
        private System.Windows.Forms.TextBox XMaximumTextBox;
        private System.Windows.Forms.Label SlopeLabel;
        private System.Windows.Forms.TextBox SlopeTextBox;
        private System.Windows.Forms.Label InterceptLabel;
        private System.Windows.Forms.TextBox InterceptTextBox;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ErrorLabelChart;
    }
}

