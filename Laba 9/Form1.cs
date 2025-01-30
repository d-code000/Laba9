namespace Laba_9;
using System.Windows.Forms.DataVisualization.Charting;

public partial class Form1 : Form
{
    private Chart _chart = new Chart();
    public Form1()
    {
        InitializeComponent();
        
        
        _chart.Size = new Size(Size.Width, 360);
        _chart.Parent = this;
        _chart.ChartAreas.Add(new ChartArea("Main"));
        
        _chart.Series.Add("Function1");
        _chart.Series.Add("Function2");
        _chart.Series["Function1"].ChartType = SeriesChartType.Line;
        _chart.Series["Function2"].ChartType = SeriesChartType.Line;
        
        // init default value
        xMinTextBox.Text = "0";
        xMaxTextBox.Text = "10";
        stepTextBox.Text = "0.01";
        
    }

    private void resultButton_Click(object sender, EventArgs e)
    {
        try
        {
            double xMin = double.Parse(xMinTextBox.Text);
            double xMax = double.Parse(xMaxTextBox.Text);
            double step = double.Parse(stepTextBox.Text);

            if (step <= 0 || xMin >= xMax)
            {
                MessageBox.Show("Некорректные значения");
                return;
            }

            _chart.Series["Function1"].Points.Clear();
            _chart.Series["Function2"].Points.Clear();

            for (double x = xMin; x <= xMax; x += step)
            {
                _chart.Series["Function1"].Points.AddXY(x, Math.Sin(x));
                _chart.Series["Function2"].Points.AddXY(x, Math.Cos(x));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
        }
    }
}