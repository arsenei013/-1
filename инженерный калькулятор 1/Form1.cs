using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace инженерный_калькулятор_1
{
    public partial class Form1 : Form
    {
        private long storedNumber = 0;
        private string pendingOperation = "";
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
            SetupCustomLayout();
            UpdateBaseRestrictions();
        }

        private void SetupCustomLayout()
        {
            this.Text = "Инженерный калькулятор (Dec, Bin, Hex)";
            this.Size = new Size(350, 530);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Size = new Size(310, 35);
            txtDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.ReadOnly = true;
            txtDisplay.Text = "0";


            rbDec.Text = "Dec (10)"; rbDec.Location = new Point(12, 55); rbDec.Checked = true; rbDec.AutoSize = true;
            rbBin.Text = "Bin (2)"; rbBin.Location = new Point(110, 55); rbBin.AutoSize = true;
            rbHex.Text = "Hex (16)"; rbHex.Location = new Point(200, 55); rbHex.AutoSize = true;

            rbDec.CheckedChanged += RadioBase_CheckedChanged;
            rbBin.CheckedChanged += RadioBase_CheckedChanged;
            rbHex.CheckedChanged += RadioBase_CheckedChanged;

            int startX = 12;
            int startY = 85;
            int w = 70;
            int h = 40;
            int gap = 10;


            ConfigureButton(btnBackspace, "←", startX, startY, w, h, Color.LightGray, BtnBackspace_Click);
            ConfigureButton(btnClear, "C", startX + (w + gap), startY, w, h, Color.LightCoral, BtnClear_Click);
            ConfigureButton(btnDiv, "/", startX + (w + gap) * 2, startY, w, h, Color.LightSteelBlue, BtnOperation_Click);
            ConfigureButton(btnMul, "*", startX + (w + gap) * 3, startY, w, h, Color.LightSteelBlue, BtnOperation_Click);


            startY += h + gap;
            ConfigureButton(btnHexA, "A", startX, startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnHexB, "B", startX + (w + gap), startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnNum7, "7", startX + (w + gap) * 2, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnNum8, "8", startX + (w + gap) * 3, startY, w, h, Color.White, BtnDigit_Click);


            startY += h + gap;
            ConfigureButton(btnHexC, "C", startX, startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnHexD, "D", startX + (w + gap), startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnNum9, "9", startX + (w + gap) * 2, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnSub, "-", startX + (w + gap) * 3, startY, w, h, Color.LightSteelBlue, BtnOperation_Click);


            startY += h + gap;
            ConfigureButton(btnHexE, "E", startX, startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnHexF, "F", startX + (w + gap), startY, w, h, Color.Beige, BtnHexDigit_Click);
            ConfigureButton(btnNum4, "4", startX + (w + gap) * 2, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnNum5, "5", startX + (w + gap) * 3, startY, w, h, Color.White, BtnDigit_Click);


            startY += h + gap;
            ConfigureButton(btnNum6, "6", startX, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnNum1, "1", startX + (w + gap), startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnNum2, "2", startX + (w + gap) * 2, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnAdd, "+", startX + (w + gap) * 3, startY, w, h, Color.LightSteelBlue, BtnOperation_Click);


            startY += h + gap;
            ConfigureButton(btnNum3, "3", startX, startY, w, h, Color.White, BtnDigit_Click);
            ConfigureButton(btnNum0, "0", startX + (w + gap), startY, w, h, Color.White, BtnDigit_Click);

            btnEquals.Location = new Point(startX + (w + gap) * 2, startY);
            btnEquals.Size = new Size((w * 2) + gap, h);
            btnEquals.Text = "=";
            btnEquals.BackColor = Color.LightGreen;
            btnEquals.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += BtnEquals_Click;


            startY += h + 15;
            lblDecResult.Text = "Dec: 0"; lblDecResult.Location = new Point(12, startY); lblDecResult.Size = new Size(310, 20); lblDecResult.Font = new Font("Segoe UI", 9F);
            startY += 20;
            lblBinResult.Text = "Bin: 0"; lblBinResult.Location = new Point(12, startY); lblBinResult.Size = new Size(310, 20); lblBinResult.Font = new Font("Segoe UI", 9F);
            startY += 20;
            lblHexResult.Text = "Hex: 0"; lblHexResult.Location = new Point(12, startY); lblHexResult.Size = new Size(310, 20); lblHexResult.Font = new Font("Segoe UI", 9F);
        }

        private void ConfigureButton(Button btn, string text, int x, int y, int width, int height, Color bgColor, EventHandler onClick)
        {
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(width, height);
            btn.UseVisualStyleBackColor = false;
            btn.BackColor = bgColor;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.Click += onClick;
        }

        private int GetCurrentBase()
        {
            if (rbBin.Checked) return 2;
            if (rbHex.Checked) return 16;
            return 10;
        }

        private long GetDisplayValue()
        {
            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "-") return 0;
            try
            {
                return Convert.ToInt64(txtDisplay.Text, GetCurrentBase());
            }
            catch
            {
                return 0;
            }
        }

        private void SetDisplayValue(long val)
        {
            int currentBase = GetCurrentBase();
            try
            {
                txtDisplay.Text = Convert.ToString(val, currentBase).ToUpper();
            }
            catch
            {
                txtDisplay.Text = "0";
            }
            UpdateLabels(val);
        }

        private void UpdateLabels(long val)
        {
            lblDecResult.Text = $"Dec: {val}";
            lblBinResult.Text = $"Bin: {Convert.ToString(val, 2)}";
            lblHexResult.Text = $"Hex: {Convert.ToString(val, 16).ToUpper()}";
        }

        private void BtnDigit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;

            if (isNewEntry || txtDisplay.Text == "0")
            {
                txtDisplay.Text = digit;
                isNewEntry = false;
            }
            else
            {
                txtDisplay.Text += digit;
            }
            UpdateLabels(GetDisplayValue());
        }

        private void BtnHexDigit_Click(object sender, EventArgs e)
        {
            BtnDigit_Click(sender, e);
        }

        private void обойтиПроверку(object sender, EventArgs e) { } // заглушка

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            storedNumber = 0;
            pendingOperation = "";
            isNewEntry = true;
            UpdateLabels(0);
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1 && !isNewEntry)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                isNewEntry = true;
            }
            UpdateLabels(GetDisplayValue());
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            storedNumber = GetDisplayValue();
            pendingOperation = btn.Text;
            isNewEntry = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pendingOperation)) return;

            long secondNumber = GetDisplayValue();
            long result = 0;

            switch (pendingOperation)
            {
                case "+": result = storedNumber + secondNumber; break;
                case "-": result = storedNumber - secondNumber; break;
                case "*": result = storedNumber * secondNumber; break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = storedNumber / secondNumber;
                    break;
            }

            SetDisplayValue(result);
            pendingOperation = "";
            isNewEntry = true;
        }

        private void RadioBase_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                long val = GetDisplayValue();
                UpdateBaseRestrictions();
                SetDisplayValue(val);
            }
        }

        private void UpdateBaseRestrictions()
        {
            int currentBase = GetCurrentBase();

            btnNum2.Enabled = (currentBase >= 2);
            btnNum3.Enabled = (currentBase >= 10);
            btnNum4.Enabled = (currentBase >= 10);
            btnNum5.Enabled = (currentBase >= 10);
            btnNum6.Enabled = (currentBase >= 10);
            btnNum7.Enabled = (currentBase >= 10);
            btnNum8.Enabled = (currentBase >= 10);
            btnNum9.Enabled = (currentBase >= 10);

            bool isHex = (currentBase == 16);
            btnHexA.Enabled = isHex;
            btnHexB.Enabled = isHex;
            btnHexC.Enabled = isHex;
            btnHexD.Enabled = isHex;
            btnHexE.Enabled = isHex;
            btnHexF.Enabled = isHex;

        }
    }
}