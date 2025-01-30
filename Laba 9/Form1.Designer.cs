namespace Laba_9;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        xMinTextBox = new System.Windows.Forms.TextBox();
        stepTextBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        xMaxTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        resultButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 387);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(198, 21);
        label1.TabIndex = 0;
        label1.Text = "Xmin";
        // 
        // xMinTextBox
        // 
        xMinTextBox.Location = new System.Drawing.Point(12, 411);
        xMinTextBox.Name = "xMinTextBox";
        xMinTextBox.Size = new System.Drawing.Size(198, 27);
        xMinTextBox.TabIndex = 1;
        // 
        // stepTextBox
        // 
        stepTextBox.Location = new System.Drawing.Point(420, 411);
        stepTextBox.Name = "stepTextBox";
        stepTextBox.Size = new System.Drawing.Size(198, 27);
        stepTextBox.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(420, 387);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(198, 21);
        label2.TabIndex = 2;
        label2.Text = "Шаг";
        // 
        // xMaxTextBox
        // 
        xMaxTextBox.Location = new System.Drawing.Point(216, 411);
        xMaxTextBox.Name = "xMaxTextBox";
        xMaxTextBox.Size = new System.Drawing.Size(198, 27);
        xMaxTextBox.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(216, 387);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(198, 21);
        label3.TabIndex = 4;
        label3.Text = "Xmax";
        // 
        // resultButton
        // 
        resultButton.Location = new System.Drawing.Point(624, 411);
        resultButton.Name = "resultButton";
        resultButton.Size = new System.Drawing.Size(139, 27);
        resultButton.TabIndex = 6;
        resultButton.Text = "Расчет!";
        resultButton.UseVisualStyleBackColor = true;
        resultButton.Click += resultButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(resultButton);
        Controls.Add(xMaxTextBox);
        Controls.Add(label3);
        Controls.Add(stepTextBox);
        Controls.Add(label2);
        Controls.Add(xMinTextBox);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox xMinTextBox;
    private System.Windows.Forms.TextBox stepTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox xMaxTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button resultButton;

    private System.Windows.Forms.Label label1;

    #endregion
}