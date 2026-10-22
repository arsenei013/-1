namespace инженерный_калькулятор_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbBin = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnHexA = new System.Windows.Forms.Button();
            this.btnHexB = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnHexC = new System.Windows.Forms.Button();
            this.btnHexD = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnHexE = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHexF = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.lblDecResult = new System.Windows.Forms.Label();
            this.lblBinResult = new System.Windows.Forms.Label();
            this.lblHexResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(59, 44);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(618, 26);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Location = new System.Drawing.Point(515, 99);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(56, 24);
            this.rbDec.TabIndex = 1;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            // 
            // rbBin
            // 
            this.rbBin.AutoSize = true;
            this.rbBin.Location = new System.Drawing.Point(515, 133);
            this.rbBin.Name = "rbBin";
            this.rbBin.Size = new System.Drawing.Size(50, 24);
            this.rbBin.TabIndex = 2;
            this.rbBin.TabStop = true;
            this.rbBin.Text = "Bin";
            this.rbBin.UseVisualStyleBackColor = true;

            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(514, 167);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(55, 24);
            this.rbHex.TabIndex = 3;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(59, 98);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(108, 27);
            this.btnBackspace.TabIndex = 4;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(287, 98);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(108, 29);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(401, 98);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(108, 29);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            // 
            // btnHexA
            // 
            this.btnHexA.Location = new System.Drawing.Point(59, 131);
            this.btnHexA.Name = "btnHexA";
            this.btnHexA.Size = new System.Drawing.Size(108, 28);
            this.btnHexA.TabIndex = 8;
            this.btnHexA.Text = "A";
            this.btnHexA.UseVisualStyleBackColor = true;
            // 
            // btnHexB
            // 
            this.btnHexB.Location = new System.Drawing.Point(59, 165);
            this.btnHexB.Name = "btnHexB";
            this.btnHexB.Size = new System.Drawing.Size(108, 28);
            this.btnHexB.TabIndex = 9;
            this.btnHexB.Text = "B";
            this.btnHexB.UseVisualStyleBackColor = true;
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(173, 133);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(108, 30);
            this.btnNum7.TabIndex = 10;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(401, 133);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(108, 32);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(287, 133);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(108, 31);
            this.btnNum8.TabIndex = 12;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(173, 235);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(108, 32);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnHexC
            // 
            this.btnHexC.Location = new System.Drawing.Point(59, 199);
            this.btnHexC.Name = "btnHexC";
            this.btnHexC.Size = new System.Drawing.Size(108, 30);
            this.btnHexC.TabIndex = 14;
            this.btnHexC.Text = "C";
            this.btnHexC.UseVisualStyleBackColor = true;
            // 
            // btnHexD
            // 
            this.btnHexD.Location = new System.Drawing.Point(59, 235);
            this.btnHexD.Name = "btnHexD";
            this.btnHexD.Size = new System.Drawing.Size(108, 32);
            this.btnHexD.TabIndex = 15;
            this.btnHexD.Text = "D";
            this.btnHexD.UseVisualStyleBackColor = true;
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(287, 167);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(108, 26);
            this.btnNum5.TabIndex = 16;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(401, 167);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(107, 27);
            this.btnNum6.TabIndex = 17;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(173, 167);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(108, 26);
            this.btnNum4.TabIndex = 18;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            // 
            // btnHexE
            // 
            this.btnHexE.Location = new System.Drawing.Point(59, 273);
            this.btnHexE.Name = "btnHexE";
            this.btnHexE.Size = new System.Drawing.Size(108, 32);
            this.btnHexE.TabIndex = 19;
            this.btnHexE.Text = "E";
            this.btnHexE.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(401, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnHexF
            // 
            this.btnHexF.Location = new System.Drawing.Point(59, 311);
            this.btnHexF.Name = "btnHexF";
            this.btnHexF.Size = new System.Drawing.Size(108, 32);
            this.btnHexF.TabIndex = 21;
            this.btnHexF.Text = "F";
            this.btnHexF.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(173, 198);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(108, 31);
            this.btnNum1.TabIndex = 22;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(287, 199);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(108, 31);
            this.btnNum2.TabIndex = 23;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(401, 200);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(107, 31);
            this.btnNum3.TabIndex = 24;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(515, 199);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 32);
            this.btnEquals.TabIndex = 25;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(287, 236);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(108, 31);
            this.btnNum0.TabIndex = 26;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            // 
            // lblDecResult
            // 
            this.lblDecResult.AutoSize = true;
            this.lblDecResult.Location = new System.Drawing.Point(173, 281);
            this.lblDecResult.Name = "lblDecResult";
            this.lblDecResult.Size = new System.Drawing.Size(55, 20);
            this.lblDecResult.TabIndex = 27;
            this.lblDecResult.Text = "Dec: 0";
            // 
            // lblBinResult
            // 
            this.lblBinResult.AutoSize = true;
            this.lblBinResult.Location = new System.Drawing.Point(283, 281);
            this.lblBinResult.Name = "lblBinResult";
            this.lblBinResult.Size = new System.Drawing.Size(49, 20);
            this.lblBinResult.TabIndex = 28;
            this.lblBinResult.Text = "Bin: 0";
            // 
            // lblHexResult
            // 
            this.lblHexResult.AutoSize = true;
            this.lblHexResult.Location = new System.Drawing.Point(397, 281);
            this.lblHexResult.Name = "lblHexResult";
            this.lblHexResult.Size = new System.Drawing.Size(54, 20);
            this.lblHexResult.TabIndex = 29;
            this.lblHexResult.Text = "Hex: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHexResult);
            this.Controls.Add(this.lblBinResult);
            this.Controls.Add(this.lblDecResult);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnHexF);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHexE);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnHexD);
            this.Controls.Add(this.btnHexC);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnHexB);
            this.Controls.Add(this.btnHexA);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.rbHex);
            this.Controls.Add(this.rbBin);
            this.Controls.Add(this.rbDec);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbBin;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnHexA;
        private System.Windows.Forms.Button btnHexB;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnHexC;
        private System.Windows.Forms.Button btnHexD;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnHexE;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHexF;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Label lblDecResult;
        private System.Windows.Forms.Label lblBinResult;
        private System.Windows.Forms.Label lblHexResult;
    }
}

