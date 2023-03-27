namespace Ej18Triangulo
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEquilateral = new System.Windows.Forms.Button();
            this.buttonSide = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericBase = new System.Windows.Forms.NumericUpDown();
            this.numericSide = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSide)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEquilateral
            // 
            this.buttonEquilateral.AutoSize = true;
            this.buttonEquilateral.Location = new System.Drawing.Point(177, 264);
            this.buttonEquilateral.Name = "buttonEquilateral";
            this.buttonEquilateral.Size = new System.Drawing.Size(94, 30);
            this.buttonEquilateral.TabIndex = 0;
            this.buttonEquilateral.Text = "Equiteral";
            this.buttonEquilateral.UseVisualStyleBackColor = true;
            this.buttonEquilateral.Click += new System.EventHandler(this.buttonEquilateral_Click);
            // 
            // buttonSide
            // 
            this.buttonSide.AutoSize = true;
            this.buttonSide.Location = new System.Drawing.Point(300, 264);
            this.buttonSide.Name = "buttonSide";
            this.buttonSide.Size = new System.Drawing.Size(83, 30);
            this.buttonSide.TabIndex = 0;
            this.buttonSide.Text = "Long side";
            this.buttonSide.Click += new System.EventHandler(this.buttonSide_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.AutoSize = true;
            this.buttonArea.Location = new System.Drawing.Point(411, 264);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(77, 30);
            this.buttonArea.TabIndex = 0;
            this.buttonArea.Text = "Get Area";
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoSize = true;
            this.buttonCreate.Location = new System.Drawing.Point(514, 264);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(115, 30);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create Tiangle";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(266, 95);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 20);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(266, 133);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 20);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(266, 172);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(38, 20);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Side";
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(338, 93);
            this.numericHeight.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(150, 27);
            this.numericHeight.TabIndex = 1;
            this.numericHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBase
            // 
            this.numericBase.Location = new System.Drawing.Point(338, 131);
            this.numericBase.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBase.Name = "numericBase";
            this.numericBase.Size = new System.Drawing.Size(150, 27);
            this.numericBase.TabIndex = 2;
            this.numericBase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericSide
            // 
            this.numericSide.Location = new System.Drawing.Point(338, 165);
            this.numericSide.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericSide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSide.Name = "numericSide";
            this.numericSide.Size = new System.Drawing.Size(150, 27);
            this.numericSide.TabIndex = 3;
            this.numericSide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(721, 386);
            this.Controls.Add(this.numericSide);
            this.Controls.Add(this.numericBase);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.buttonEquilateral);
            this.Controls.Add(this.buttonSide);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEquilateral;
        private Button buttonSide;
        private Button buttonArea;
        private Button buttonCreate;
        private Label lblHeight;
        private Label lblBase;
        private Label lblSide;
        private NumericUpDown numericHeight;
        private NumericUpDown numericBase;
        private NumericUpDown numericSide;
    }
}