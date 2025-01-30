namespace Laba_9;
using System.Windows.Forms.DataVisualization.Charting;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        Chart chart = new Chart();
        chart.Size = new Size(Size.Width, 360);
        chart.Parent = this;
    }

    private void resultButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}