namespace WindowsFormsApp1
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
            this.dgBaseMatrix = new System.Windows.Forms.DataGridView();
            this.txtMatrixI = new System.Windows.Forms.TextBox();
            this.txtMatrixJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.dgTurnedMatrix = new System.Windows.Forms.DataGridView();
            this.cbChooseDegree = new System.Windows.Forms.ComboBox();
            this.btnTurn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaseMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnedMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBaseMatrix
            // 
            this.dgBaseMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBaseMatrix.Location = new System.Drawing.Point(13, 13);
            this.dgBaseMatrix.Name = "dgBaseMatrix";
            this.dgBaseMatrix.RowHeadersWidth = 51;
            this.dgBaseMatrix.RowTemplate.Height = 24;
            this.dgBaseMatrix.Size = new System.Drawing.Size(449, 450);
            this.dgBaseMatrix.TabIndex = 0;
            // 
            // txtMatrixI
            // 
            this.txtMatrixI.Location = new System.Drawing.Point(531, 44);
            this.txtMatrixI.Name = "txtMatrixI";
            this.txtMatrixI.Size = new System.Drawing.Size(100, 22);
            this.txtMatrixI.TabIndex = 1;
            // 
            // txtMatrixJ
            // 
            this.txtMatrixJ.Location = new System.Drawing.Point(531, 83);
            this.txtMatrixJ.Name = "txtMatrixJ";
            this.txtMatrixJ.Size = new System.Drawing.Size(100, 22);
            this.txtMatrixJ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrix Sizes";
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.Location = new System.Drawing.Point(531, 128);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(100, 41);
            this.btnGenerateMatrix.TabIndex = 4;
            this.btnGenerateMatrix.Text = "Generate Matrix";
            this.btnGenerateMatrix.UseVisualStyleBackColor = true;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // dgTurnedMatrix
            // 
            this.dgTurnedMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTurnedMatrix.Location = new System.Drawing.Point(699, 13);
            this.dgTurnedMatrix.Name = "dgTurnedMatrix";
            this.dgTurnedMatrix.RowHeadersWidth = 51;
            this.dgTurnedMatrix.RowTemplate.Height = 24;
            this.dgTurnedMatrix.Size = new System.Drawing.Size(449, 450);
            this.dgTurnedMatrix.TabIndex = 5;
            // 
            // cbChooseDegree
            // 
            this.cbChooseDegree.FormattingEnabled = true;
            this.cbChooseDegree.Location = new System.Drawing.Point(531, 272);
            this.cbChooseDegree.Name = "cbChooseDegree";
            this.cbChooseDegree.Size = new System.Drawing.Size(100, 24);
            this.cbChooseDegree.TabIndex = 6;
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(531, 327);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(100, 26);
            this.btnTurn.TabIndex = 7;
            this.btnTurn.Text = "Turn";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 687);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.cbChooseDegree);
            this.Controls.Add(this.dgTurnedMatrix);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatrixJ);
            this.Controls.Add(this.txtMatrixI);
            this.Controls.Add(this.dgBaseMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBaseMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTurnedMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBaseMatrix;
        private System.Windows.Forms.TextBox txtMatrixI;
        private System.Windows.Forms.TextBox txtMatrixJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.DataGridView dgTurnedMatrix;
        private System.Windows.Forms.ComboBox cbChooseDegree;
        private System.Windows.Forms.Button btnTurn;
    }
}

