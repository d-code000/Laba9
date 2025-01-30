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
        
        // init default value
        xMinTextBox.Text = "0.12";
        xMaxTextBox.Text = "0.64";
        
        stepTextBox.Text = "0.2";
        
    }

    private void resultButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private double Func(double x)
    {
        return 
            Math.Pow
            (
            Math.Log(Math.Sin(Math.Pow(x, 3) + 0.0025)), 
            3.0 / 2
            ) + 
            0.8 * Math.Pow(10, -3);
    }
}