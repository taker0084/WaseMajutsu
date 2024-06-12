namespace unilab2024
{
    partial class Stage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_ResetInput = new System.Windows.Forms.Button();
            this.button_ResetA = new System.Windows.Forms.Button();
            this.button_ResetB = new System.Windows.Forms.Button();
            this.button_ToMap = new System.Windows.Forms.Button();
            this.button_Retry = new System.Windows.Forms.Button();
            this.button_NextStage = new System.Windows.Forms.Button();
            this.button_Hint = new System.Windows.Forms.Button();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.listBox_Options = new System.Windows.Forms.ListBox();
            this.listBox_A = new System.Windows.Forms.ListBox();
            this.listBox_B = new System.Windows.Forms.ListBox();
            this.listBox_SelectAB = new System.Windows.Forms.ListBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_Input = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 540);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(72, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(540, 540);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox3.Location = new System.Drawing.Point(61, 685);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(832, 89);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Start.Font = new System.Drawing.Font("游明朝 Demibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Start.ForeColor = System.Drawing.Color.Navy;
            this.button_Start.Location = new System.Drawing.Point(1120, 598);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(223, 100);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "出発！";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_ResetInput
            // 
            this.button_ResetInput.Location = new System.Drawing.Point(697, 97);
            this.button_ResetInput.Name = "button_ResetInput";
            this.button_ResetInput.Size = new System.Drawing.Size(54, 24);
            this.button_ResetInput.TabIndex = 4;
            this.button_ResetInput.Text = "リセット";
            this.button_ResetInput.UseVisualStyleBackColor = true;
            this.button_ResetInput.Click += new System.EventHandler(this.button_ResetInput_Click);
            // 
            // button_ResetA
            // 
            this.button_ResetA.Location = new System.Drawing.Point(955, 97);
            this.button_ResetA.Name = "button_ResetA";
            this.button_ResetA.Size = new System.Drawing.Size(54, 24);
            this.button_ResetA.TabIndex = 5;
            this.button_ResetA.Text = "リセット";
            this.button_ResetA.UseVisualStyleBackColor = true;
            this.button_ResetA.Click += new System.EventHandler(this.button_ResetA_Click);
            // 
            // button_ResetB
            // 
            this.button_ResetB.Location = new System.Drawing.Point(1217, 97);
            this.button_ResetB.Name = "button_ResetB";
            this.button_ResetB.Size = new System.Drawing.Size(54, 24);
            this.button_ResetB.TabIndex = 6;
            this.button_ResetB.Text = "リセット";
            this.button_ResetB.UseVisualStyleBackColor = true;
            this.button_ResetB.Click += new System.EventHandler(this.button_ResetB_Click);
            // 
            // button_ToMap
            // 
            this.button_ToMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_ToMap.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ToMap.ForeColor = System.Drawing.Color.White;
            this.button_ToMap.Location = new System.Drawing.Point(1148, 12);
            this.button_ToMap.Name = "button_ToMap";
            this.button_ToMap.Size = new System.Drawing.Size(158, 46);
            this.button_ToMap.TabIndex = 7;
            this.button_ToMap.Text = "マップに戻る";
            this.button_ToMap.UseVisualStyleBackColor = false;
            this.button_ToMap.Click += new System.EventHandler(this.button_ToMap_Click);
            // 
            // button_Retry
            // 
            this.button_Retry.BackColor = System.Drawing.Color.Tomato;
            this.button_Retry.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Retry.ForeColor = System.Drawing.Color.White;
            this.button_Retry.Location = new System.Drawing.Point(1184, 724);
            this.button_Retry.Name = "button_Retry";
            this.button_Retry.Size = new System.Drawing.Size(223, 50);
            this.button_Retry.TabIndex = 8;
            this.button_Retry.Text = "リトライ！";
            this.button_Retry.UseVisualStyleBackColor = false;
            this.button_Retry.Click += new System.EventHandler(this.button_Retry_Click);
            // 
            // button_NextStage
            // 
            this.button_NextStage.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_NextStage.Location = new System.Drawing.Point(1243, 501);
            this.button_NextStage.Name = "button_NextStage";
            this.button_NextStage.Size = new System.Drawing.Size(215, 82);
            this.button_NextStage.TabIndex = 9;
            this.button_NextStage.Text = "次のステージへ！";
            this.button_NextStage.UseVisualStyleBackColor = true;
            // 
            // button_Hint
            // 
            this.button_Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Hint.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Hint.ForeColor = System.Drawing.Color.Black;
            this.button_Hint.Location = new System.Drawing.Point(923, 685);
            this.button_Hint.Name = "button_Hint";
            this.button_Hint.Size = new System.Drawing.Size(132, 89);
            this.button_Hint.TabIndex = 10;
            this.button_Hint.Text = "ヒント！";
            this.button_Hint.UseVisualStyleBackColor = false;
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_Input.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 35;
            this.listBox_Input.Location = new System.Drawing.Point(697, 127);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(241, 144);
            this.listBox_Input.TabIndex = 11;
            // 
            // listBox_Options
            // 
            this.listBox_Options.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_Options.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_Options.FormattingEnabled = true;
            this.listBox_Options.ItemHeight = 35;
            this.listBox_Options.Location = new System.Drawing.Point(923, 401);
            this.listBox_Options.Name = "listBox_Options";
            this.listBox_Options.Size = new System.Drawing.Size(241, 144);
            this.listBox_Options.TabIndex = 12;
            // 
            // listBox_A
            // 
            this.listBox_A.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_A.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_A.FormattingEnabled = true;
            this.listBox_A.ItemHeight = 35;
            this.listBox_A.Location = new System.Drawing.Point(955, 127);
            this.listBox_A.Name = "listBox_A";
            this.listBox_A.Size = new System.Drawing.Size(241, 144);
            this.listBox_A.TabIndex = 13;
            // 
            // listBox_B
            // 
            this.listBox_B.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_B.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_B.FormattingEnabled = true;
            this.listBox_B.ItemHeight = 35;
            this.listBox_B.Location = new System.Drawing.Point(1217, 127);
            this.listBox_B.Name = "listBox_B";
            this.listBox_B.Size = new System.Drawing.Size(241, 144);
            this.listBox_B.TabIndex = 14;
            // 
            // listBox_SelectAB
            // 
            this.listBox_SelectAB.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_SelectAB.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_SelectAB.FormattingEnabled = true;
            this.listBox_SelectAB.ItemHeight = 35;
            this.listBox_SelectAB.Location = new System.Drawing.Point(1200, 401);
            this.listBox_SelectAB.Name = "listBox_SelectAB";
            this.listBox_SelectAB.Size = new System.Drawing.Size(143, 39);
            this.listBox_SelectAB.TabIndex = 15;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.White;
            this.label_Result.Font = new System.Drawing.Font("游明朝 Demibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Result.ForeColor = System.Drawing.Color.Red;
            this.label_Result.Location = new System.Drawing.Point(236, 333);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(227, 83);
            this.label_Result.TabIndex = 16;
            this.label_Result.Text = "ミス！";
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.Color.White;
            this.label_Input.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Input.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Input.Location = new System.Drawing.Point(757, 84);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(96, 27);
            this.label_Input.TabIndex = 17;
            this.label_Input.Text = "起動の術";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.BackColor = System.Drawing.Color.White;
            this.label_A.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_A.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_A.Location = new System.Drawing.Point(1015, 84);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(90, 27);
            this.label_A.TabIndex = 18;
            this.label_A.Text = "Aの魔法";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.BackColor = System.Drawing.Color.White;
            this.label_B.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_B.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_B.Location = new System.Drawing.Point(1277, 84);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(90, 27);
            this.label_B.TabIndex = 19;
            this.label_B.Text = "Bの魔法";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.BackColor = System.Drawing.Color.White;
            this.label_Error.Font = new System.Drawing.Font("游明朝 Demibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(48, 240);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(227, 83);
            this.label_Error.TabIndex = 20;
            this.label_Error.Text = "ミス！";
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("游明朝", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Info.Location = new System.Drawing.Point(598, 198);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(153, 62);
            this.label_Info.TabIndex = 21;
            this.label_Info.Text = "label4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(715, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 104);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(819, 401);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 104);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox6.Location = new System.Drawing.Point(715, 501);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 104);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox7.Location = new System.Drawing.Point(819, 501);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 104);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1520, 861);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.listBox_SelectAB);
            this.Controls.Add(this.listBox_B);
            this.Controls.Add(this.listBox_A);
            this.Controls.Add(this.listBox_Options);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.button_Hint);
            this.Controls.Add(this.button_NextStage);
            this.Controls.Add(this.button_Retry);
            this.Controls.Add(this.button_ToMap);
            this.Controls.Add(this.button_ResetB);
            this.Controls.Add(this.button_ResetA);
            this.Controls.Add(this.button_ResetInput);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Stage";
            this.Text = "ゲーム画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_ResetInput;
        private System.Windows.Forms.Button button_ResetA;
        private System.Windows.Forms.Button button_ResetB;
        private System.Windows.Forms.Button button_ToMap;
        private System.Windows.Forms.Button button_Retry;
        private System.Windows.Forms.Button button_NextStage;
        private System.Windows.Forms.Button button_Hint;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.ListBox listBox_Options;
        private System.Windows.Forms.ListBox listBox_A;
        private System.Windows.Forms.ListBox listBox_B;
        private System.Windows.Forms.ListBox listBox_SelectAB;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}