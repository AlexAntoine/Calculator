namespace Calculator
{
    partial class frmCalculator
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
            this.lblCalculator = new System.Windows.Forms.Label();
            this.grpExtraFunctions = new System.Windows.Forms.GroupBox();
            this.grpNormalFunctions = new System.Windows.Forms.GroupBox();
            this.txtInputFirstNumber = new System.Windows.Forms.TextBox();
            this.txtInputSecondNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnIntegerDivision = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpExtraFunctions.SuspendLayout();
            this.grpNormalFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(396, 38);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(251, 58);
            this.lblCalculator.TabIndex = 0;
            this.lblCalculator.Text = "Calculator";
            this.lblCalculator.Click += new System.EventHandler(this.lblCalculator_Click);
            // 
            // grpExtraFunctions
            // 
            this.grpExtraFunctions.Controls.Add(this.btnPercent);
            this.grpExtraFunctions.Controls.Add(this.btnIntegerDivision);
            this.grpExtraFunctions.Controls.Add(this.btnModulus);
            this.grpExtraFunctions.Location = new System.Drawing.Point(723, 139);
            this.grpExtraFunctions.Name = "grpExtraFunctions";
            this.grpExtraFunctions.Size = new System.Drawing.Size(352, 222);
            this.grpExtraFunctions.TabIndex = 1;
            this.grpExtraFunctions.TabStop = false;
            this.grpExtraFunctions.Text = "Pick A Function";
            this.grpExtraFunctions.Enter += new System.EventHandler(this.grpExtraFunctions_Enter);
            // 
            // grpNormalFunctions
            // 
            this.grpNormalFunctions.Controls.Add(this.btnMultiply);
            this.grpNormalFunctions.Controls.Add(this.btnDivide);
            this.grpNormalFunctions.Controls.Add(this.btnSubtract);
            this.grpNormalFunctions.Controls.Add(this.btnAdd);
            this.grpNormalFunctions.Location = new System.Drawing.Point(39, 139);
            this.grpNormalFunctions.Name = "grpNormalFunctions";
            this.grpNormalFunctions.Size = new System.Drawing.Size(279, 222);
            this.grpNormalFunctions.TabIndex = 2;
            this.grpNormalFunctions.TabStop = false;
            this.grpNormalFunctions.Text = "Pick A Function";
            this.grpNormalFunctions.Enter += new System.EventHandler(this.grpNormalFunctions_Enter);
            // 
            // txtInputFirstNumber
            // 
            this.txtInputFirstNumber.Location = new System.Drawing.Point(425, 170);
            this.txtInputFirstNumber.MaxLength = 45000;
            this.txtInputFirstNumber.Multiline = true;
            this.txtInputFirstNumber.Name = "txtInputFirstNumber";
            this.txtInputFirstNumber.Size = new System.Drawing.Size(170, 44);
            this.txtInputFirstNumber.TabIndex = 3;
            this.txtInputFirstNumber.Text = "Input First Number";
            this.txtInputFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInputSecondNumber
            // 
            this.txtInputSecondNumber.Location = new System.Drawing.Point(425, 279);
            this.txtInputSecondNumber.MaxLength = 45000;
            this.txtInputSecondNumber.Multiline = true;
            this.txtInputSecondNumber.Name = "txtInputSecondNumber";
            this.txtInputSecondNumber.Size = new System.Drawing.Size(178, 46);
            this.txtInputSecondNumber.TabIndex = 4;
            this.txtInputSecondNumber.Text = "Input Second Number";
            this.txtInputSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(171, 52);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(86, 43);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(26, 128);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(86, 40);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(171, 132);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(86, 36);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Location = new System.Drawing.Point(21, 56);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(143, 44);
            this.btnModulus.TabIndex = 0;
            this.btnModulus.Text = "Modululs";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btnModulus_Click);
            // 
            // btnIntegerDivision
            // 
            this.btnIntegerDivision.Location = new System.Drawing.Point(190, 56);
            this.btnIntegerDivision.Name = "btnIntegerDivision";
            this.btnIntegerDivision.Size = new System.Drawing.Size(143, 44);
            this.btnIntegerDivision.TabIndex = 1;
            this.btnIntegerDivision.Text = "Integer Divsion";
            this.btnIntegerDivision.UseVisualStyleBackColor = true;
            this.btnIntegerDivision.Click += new System.EventHandler(this.btnIntegerDivision_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(89, 132);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(143, 42);
            this.btnPercent.TabIndex = 2;
            this.btnPercent.Text = "Percent";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(812, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(425, 368);
            this.txtResult.MaxLength = 45000;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(178, 42);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 556);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtInputSecondNumber);
            this.Controls.Add(this.txtInputFirstNumber);
            this.Controls.Add(this.grpNormalFunctions);
            this.Controls.Add(this.grpExtraFunctions);
            this.Controls.Add(this.lblCalculator);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.grpExtraFunctions.ResumeLayout(false);
            this.grpNormalFunctions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.GroupBox grpExtraFunctions;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnIntegerDivision;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.GroupBox grpNormalFunctions;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInputFirstNumber;
        private System.Windows.Forms.TextBox txtInputSecondNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResult;
    }
}

