namespace firstExp
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
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_grid_50 = new System.Windows.Forms.Button();
            this.btn_grid_100 = new System.Windows.Forms.Button();
            this.btn_grid_200 = new System.Windows.Forms.Button();
            this.btn_grid_500 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_grid_1000 = new System.Windows.Forms.Button();
            this.btn_OpenColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_OnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(12, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(737, 534);
            this.formsPlot1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "TimeSW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_grid_50
            // 
            this.btn_grid_50.Location = new System.Drawing.Point(60, 595);
            this.btn_grid_50.Name = "btn_grid_50";
            this.btn_grid_50.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_50.TabIndex = 2;
            this.btn_grid_50.Text = "grid_50";
            this.btn_grid_50.UseVisualStyleBackColor = true;
            this.btn_grid_50.Click += new System.EventHandler(this.grid_button_click);
            // 
            // btn_grid_100
            // 
            this.btn_grid_100.Location = new System.Drawing.Point(60, 624);
            this.btn_grid_100.Name = "btn_grid_100";
            this.btn_grid_100.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_100.TabIndex = 3;
            this.btn_grid_100.Text = "grid_100";
            this.btn_grid_100.UseVisualStyleBackColor = true;
            this.btn_grid_100.Click += new System.EventHandler(this.grid_button_click);
            // 
            // btn_grid_200
            // 
            this.btn_grid_200.Location = new System.Drawing.Point(60, 653);
            this.btn_grid_200.Name = "btn_grid_200";
            this.btn_grid_200.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_200.TabIndex = 4;
            this.btn_grid_200.Text = "grid_200";
            this.btn_grid_200.UseVisualStyleBackColor = true;
            this.btn_grid_200.Click += new System.EventHandler(this.grid_button_click);
            // 
            // btn_grid_500
            // 
            this.btn_grid_500.Location = new System.Drawing.Point(60, 682);
            this.btn_grid_500.Name = "btn_grid_500";
            this.btn_grid_500.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_500.TabIndex = 5;
            this.btn_grid_500.Text = "grid_500";
            this.btn_grid_500.UseVisualStyleBackColor = true;
            this.btn_grid_500.Click += new System.EventHandler(this.grid_button_click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_grid_1000
            // 
            this.btn_grid_1000.Location = new System.Drawing.Point(60, 711);
            this.btn_grid_1000.Name = "btn_grid_1000";
            this.btn_grid_1000.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_1000.TabIndex = 6;
            this.btn_grid_1000.Text = "grid_1000";
            this.btn_grid_1000.UseVisualStyleBackColor = true;
            this.btn_grid_1000.Click += new System.EventHandler(this.grid_button_click);
            // 
            // btn_OpenColor
            // 
            this.btn_OpenColor.Location = new System.Drawing.Point(169, 552);
            this.btn_OpenColor.Name = "btn_OpenColor";
            this.btn_OpenColor.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenColor.TabIndex = 7;
            this.btn_OpenColor.Text = "OpenColor";
            this.btn_OpenColor.UseVisualStyleBackColor = true;
            this.btn_OpenColor.Click += new System.EventHandler(this.btn_OpenColor_Click);
            // 
            // btn_OnOff
            // 
            this.btn_OnOff.Location = new System.Drawing.Point(169, 595);
            this.btn_OnOff.Name = "btn_OnOff";
            this.btn_OnOff.Size = new System.Drawing.Size(75, 23);
            this.btn_OnOff.TabIndex = 8;
            this.btn_OnOff.Text = "OnOff";
            this.btn_OnOff.UseVisualStyleBackColor = true;
            this.btn_OnOff.Click += new System.EventHandler(this.btn_OnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btn_OnOff);
            this.Controls.Add(this.btn_OpenColor);
            this.Controls.Add(this.btn_grid_1000);
            this.Controls.Add(this.btn_grid_500);
            this.Controls.Add(this.btn_grid_200);
            this.Controls.Add(this.btn_grid_100);
            this.Controls.Add(this.btn_grid_50);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_grid_50;
        private System.Windows.Forms.Button btn_grid_100;
        private System.Windows.Forms.Button btn_grid_200;
        private System.Windows.Forms.Button btn_grid_500;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_grid_1000;
        private System.Windows.Forms.Button btn_OpenColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_OnOff;
    }
}

