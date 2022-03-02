namespace ControlFlots.fFRA
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_SaveInReference = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.chk_DottedLine = new System.Windows.Forms.CheckBox();
            this.chk_MagMain = new System.Windows.Forms.CheckBox();
            this.chk_MagBack = new System.Windows.Forms.CheckBox();
            this.chk_PhaBack = new System.Windows.Forms.CheckBox();
            this.chk_PhaMain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(12, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(622, 557);
            this.formsPlot1.TabIndex = 0;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(46, 621);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(227, 23);
            this.btn_input.TabIndex = 49;
            this.btn_input.Text = "FRA_SampleDataInput(실시간)";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.Click_DataProcess);
            // 
            // btn_SaveInReference
            // 
            this.btn_SaveInReference.Location = new System.Drawing.Point(46, 679);
            this.btn_SaveInReference.Name = "btn_SaveInReference";
            this.btn_SaveInReference.Size = new System.Drawing.Size(227, 23);
            this.btn_SaveInReference.TabIndex = 48;
            this.btn_SaveInReference.Text = "SaveInBackground";
            this.btn_SaveInReference.UseVisualStyleBackColor = true;
            this.btn_SaveInReference.Click += new System.EventHandler(this.Click_DataProcess);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(46, 650);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(227, 23);
            this.btn_Clear.TabIndex = 47;
            this.btn_Clear.Text = "ClearMainDATA";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Click_DataProcess);
            // 
            // chk_DottedLine
            // 
            this.chk_DottedLine.AutoSize = true;
            this.chk_DottedLine.Location = new System.Drawing.Point(468, 621);
            this.chk_DottedLine.Name = "chk_DottedLine";
            this.chk_DottedLine.Size = new System.Drawing.Size(83, 16);
            this.chk_DottedLine.TabIndex = 55;
            this.chk_DottedLine.Text = "DottedLine";
            this.chk_DottedLine.UseVisualStyleBackColor = true;
            this.chk_DottedLine.CheckedChanged += new System.EventHandler(this.chk_DottedLine_CheckedChanged);
            // 
            // chk_MagMain
            // 
            this.chk_MagMain.AutoSize = true;
            this.chk_MagMain.Location = new System.Drawing.Point(340, 621);
            this.chk_MagMain.Name = "chk_MagMain";
            this.chk_MagMain.Size = new System.Drawing.Size(103, 16);
            this.chk_MagMain.TabIndex = 68;
            this.chk_MagMain.Text = "chk_MagMain";
            this.chk_MagMain.UseVisualStyleBackColor = true;
            this.chk_MagMain.CheckedChanged += new System.EventHandler(this.Check_Visible);
            // 
            // chk_MagBack
            // 
            this.chk_MagBack.AutoSize = true;
            this.chk_MagBack.Location = new System.Drawing.Point(340, 679);
            this.chk_MagBack.Name = "chk_MagBack";
            this.chk_MagBack.Size = new System.Drawing.Size(103, 16);
            this.chk_MagBack.TabIndex = 69;
            this.chk_MagBack.Text = "chk_MagBack";
            this.chk_MagBack.UseVisualStyleBackColor = true;
            this.chk_MagBack.CheckedChanged += new System.EventHandler(this.Check_Visible);
            // 
            // chk_PhaBack
            // 
            this.chk_PhaBack.AutoSize = true;
            this.chk_PhaBack.Location = new System.Drawing.Point(340, 701);
            this.chk_PhaBack.Name = "chk_PhaBack";
            this.chk_PhaBack.Size = new System.Drawing.Size(100, 16);
            this.chk_PhaBack.TabIndex = 70;
            this.chk_PhaBack.Text = "chk_PhaBack";
            this.chk_PhaBack.UseVisualStyleBackColor = true;
            this.chk_PhaBack.CheckedChanged += new System.EventHandler(this.Check_Visible);
            // 
            // chk_PhaMain
            // 
            this.chk_PhaMain.AutoSize = true;
            this.chk_PhaMain.Location = new System.Drawing.Point(340, 643);
            this.chk_PhaMain.Name = "chk_PhaMain";
            this.chk_PhaMain.Size = new System.Drawing.Size(100, 16);
            this.chk_PhaMain.TabIndex = 71;
            this.chk_PhaMain.Text = "chk_PhaMain";
            this.chk_PhaMain.UseVisualStyleBackColor = true;
            this.chk_PhaMain.CheckedChanged += new System.EventHandler(this.Check_Visible);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.chk_PhaMain);
            this.Controls.Add(this.chk_PhaBack);
            this.Controls.Add(this.chk_MagBack);
            this.Controls.Add(this.chk_MagMain);
            this.Controls.Add(this.chk_DottedLine);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.btn_SaveInReference);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_SaveInReference;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.CheckBox chk_DottedLine;
        private System.Windows.Forms.CheckBox chk_MagMain;
        private System.Windows.Forms.CheckBox chk_MagBack;
        private System.Windows.Forms.CheckBox chk_PhaBack;
        private System.Windows.Forms.CheckBox chk_PhaMain;
    }
}

