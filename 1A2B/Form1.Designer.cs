namespace _1A2B
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lnlAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 53);
            this.txtInput.MaxLength = 4;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(12, 96);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuess.Size = new System.Drawing.Size(263, 297);
            this.txtGuess.TabIndex = 1;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 24);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(118, 51);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "輸入";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(183, 396);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "看答案";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lnlAnswer
            // 
            this.lnlAnswer.AutoSize = true;
            this.lnlAnswer.Location = new System.Drawing.Point(264, 401);
            this.lnlAnswer.Name = "lnlAnswer";
            this.lnlAnswer.Size = new System.Drawing.Size(33, 12);
            this.lnlAnswer.TabIndex = 5;
            this.lnlAnswer.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 433);
            this.Controls.Add(this.lnlAnswer);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(319, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(319, 476);
            this.Name = "Form1";
            this.Text = "1A2B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lnlAnswer;
    }
}

