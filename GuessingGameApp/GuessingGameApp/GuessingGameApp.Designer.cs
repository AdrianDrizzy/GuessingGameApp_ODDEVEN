namespace GuessingGameApp
{
    partial class GuessingGameAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1411, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "How quickly can you guess the random number?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "What number  ( 0 - 100 ) ?";
            // 
            // txtBxGuess
            // 
            this.txtBxGuess.Location = new System.Drawing.Point(343, 123);
            this.txtBxGuess.Name = "txtBxGuess";
            this.txtBxGuess.Size = new System.Drawing.Size(71, 95);
            this.txtBxGuess.TabIndex = 0;
            this.txtBxGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 69);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guess Count:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(319, 182);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(67, 69);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "0";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.White;
            this.btnGuess.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.Black;
            this.btnGuess.Location = new System.Drawing.Point(201, 237);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(121, 51);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(421, 413);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(127, 362);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 69);
            this.lblMsg.TabIndex = 7;
            // 
            // GuessingGameAppForm
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(34F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(535, 473);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GuessingGameAppForm";
            this.Text = "Guessing Game App";
            this.Load += new System.EventHandler(this.GuessingGameAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMsg;
    }
}

