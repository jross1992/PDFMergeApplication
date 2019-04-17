namespace mergePdf
{
    partial class PDFMERGE
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
            this.button1Clr = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSelectFile1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPdfFile1Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1clrAll = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Clr
            // 
            this.button1Clr.BackColor = System.Drawing.Color.White;
            this.button1Clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Clr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clr.Location = new System.Drawing.Point(525, 270);
            this.button1Clr.Name = "button1Clr";
            this.button1Clr.Size = new System.Drawing.Size(75, 25);
            this.button1Clr.TabIndex = 17;
            this.button1Clr.Text = "Clear File";
            this.button1Clr.UseVisualStyleBackColor = false;
            this.button1Clr.Click += new System.EventHandler(this.button1Clr_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.White;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(1, 502);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(106, 25);
            this.btnMerge.TabIndex = 16;
            this.btnMerge.Text = "Merge PDF Files";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSelectFile1
            // 
            this.btnSelectFile1.BackColor = System.Drawing.Color.White;
            this.btnSelectFile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile1.ImageList = this.imageList1;
            this.btnSelectFile1.Location = new System.Drawing.Point(525, 77);
            this.btnSelectFile1.Name = "btnSelectFile1";
            this.btnSelectFile1.Size = new System.Drawing.Size(75, 25);
            this.btnSelectFile1.TabIndex = 17;
            this.btnSelectFile1.Text = "Select File";
            this.btnSelectFile1.UseVisualStyleBackColor = false;
            this.btnSelectFile1.Click += new System.EventHandler(this.btnSelectFile1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "PDF File:";
            // 
            // textBoxPdfFile1Path
            // 
            this.textBoxPdfFile1Path.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPdfFile1Path.Location = new System.Drawing.Point(78, 79);
            this.textBoxPdfFile1Path.Name = "textBoxPdfFile1Path";
            this.textBoxPdfFile1Path.Size = new System.Drawing.Size(441, 22);
            this.textBoxPdfFile1Path.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "PDF Merge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(78, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(442, 334);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1clrAll
            // 
            this.button1clrAll.BackColor = System.Drawing.Color.White;
            this.button1clrAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1clrAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1clrAll.Location = new System.Drawing.Point(525, 502);
            this.button1clrAll.Name = "button1clrAll";
            this.button1clrAll.Size = new System.Drawing.Size(75, 25);
            this.button1clrAll.TabIndex = 18;
            this.button1clrAll.Text = "Clear All";
            this.button1clrAll.UseVisualStyleBackColor = false;
            this.button1clrAll.Click += new System.EventHandler(this.button1clrAll_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(17, 121);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(55, 20);
            this.buttonUp.TabIndex = 13;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(17, 157);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(55, 20);
            this.buttonDown.TabIndex = 14;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(612, 610);
            this.Controls.Add(this.button1clrAll);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1Clr);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSelectFile1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPdfFile1Path);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Pdf Merge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnMerge;
    private System.Windows.Forms.Button btnSelectFile1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxPdfFile1Path;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button buttonDown;
    private System.Windows.Forms.Button buttonUp;
    private System.Windows.Forms.Button button1Clr;
    private System.Windows.Forms.Button button1clrAll;
    private System.Windows.Forms.ImageList imageList1;
    }
}

