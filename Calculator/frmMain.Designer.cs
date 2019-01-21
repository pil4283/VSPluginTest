namespace Calculator
{
    partial class CalculatorMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.dotButton = new System.Windows.Forms.Button();
            this.calProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(270, 425);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(50, 50);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(270, 355);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(50, 50);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(270, 285);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(50, 50);
            this.divButton.TabIndex = 4;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(270, 215);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(50, 50);
            this.mulButton.TabIndex = 4;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(190, 425);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(50, 50);
            this.equalButton.TabIndex = 0;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.EqualButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(30, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "C";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(110, 425);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(50, 50);
            this.zeroButton.TabIndex = 3;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(190, 355);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(50, 50);
            this.nineButton.TabIndex = 4;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(110, 355);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(50, 50);
            this.eightButton.TabIndex = 4;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(30, 355);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(50, 50);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(190, 285);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(50, 50);
            this.sixButton.TabIndex = 4;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(110, 285);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(50, 50);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(30, 285);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(50, 50);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(190, 215);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(50, 50);
            this.threeButton.TabIndex = 4;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(110, 215);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(50, 50);
            this.twoButton.TabIndex = 4;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(30, 215);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(50, 50);
            this.oneButton.TabIndex = 4;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AcceptsReturn = true;
            this.inputTextBox.Font = new System.Drawing.Font("굴림", 18F);
            this.inputTextBox.Location = new System.Drawing.Point(30, 99);
            this.inputTextBox.MaxLength = 100;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ShortcutsEnabled = false;
            this.inputTextBox.Size = new System.Drawing.Size(290, 35);
            this.inputTextBox.TabIndex = 5;
            this.inputTextBox.Text = "0";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputTextBox.UseWaitCursor = true;
            this.inputTextBox.WordWrap = false;
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(149, 159);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(50, 50);
            this.dotButton.TabIndex = 6;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // calProgressLabel
            // 계산과정 표시용
            // 
            this.calProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calProgressLabel.Font = new System.Drawing.Font("굴림", 15F);
            this.calProgressLabel.Location = new System.Drawing.Point(30, 44);
            this.calProgressLabel.Name = "calProgressLabel";
            this.calProgressLabel.Size = new System.Drawing.Size(290, 30);
            this.calProgressLabel.TabIndex = 7;
            this.calProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 509);
            this.Controls.Add(this.calProgressLabel);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Name = "CalculatorMainForm";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Label calProgressLabel;
    }
}

