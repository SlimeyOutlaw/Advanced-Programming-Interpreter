using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int lineNumber = 0;
        private readonly List<Color> Colors = new List<Color>() { Color.Blue, Color.Red, Color.Purple, Color.Green, Color.Brown, Color.Black };
        public Form()
        {
            InitializeComponent();
            this.Text = "Expression Interpreter & Simple Graphing";

            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 5;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["ChartArea1"].CursorX.AutoScroll = true;
            chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabel.Text = "";
                string userInput = InputTextBox.Text;
                float output = (float)MathExpressionIntepreter.Evaluate(userInput);
                OutputTextBox.Text = output.ToString();
            } catch (Exception exception)
                {
                    ErrorLabel.Text = exception.Message;
                }
            
        }

        private void GraphButton_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLabelChart.Text = "";
                float XMin = float.Parse(XMinTextBox.Text);
                float XMax = float.Parse(XMaximumTextBox.Text);

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = XMin;
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = XMax;

                string slope = SlopeTextBox.Text;
                string intercept = InterceptTextBox.Text;


                chart1.Series.Add(lineNumber.ToString());
                chart1.Series[lineNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                if (lineNumber >= Colors.Count())
                {
                    chart1.Series[lineNumber].Color = Colors[lineNumber - Colors.Count()];
                }
                else
                {
                    chart1.Series[lineNumber].Color = Colors[lineNumber];
                }

                for (double i = XMin; i <= XMax; i += 0.1)
                {
                    chart1.Series[lineNumber].Points.AddXY(i, (i * float.Parse(slope)) + float.Parse(intercept));
                }

                lineNumber++;
            } catch (Exception exception)
                {
                    ErrorLabelChart.Text = exception.Message;
                    chart1.Series.Remove( chart1.Series.FindByName(lineNumber.ToString()) );
                }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            lineNumber = 0;
        }
    }
}
