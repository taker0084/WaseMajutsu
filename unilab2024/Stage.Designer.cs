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
            this.button_start = new System.Windows.Forms.Button();
            this.button_ResetInput = new System.Windows.Forms.Button();
            this.button_ResetA = new System.Windows.Forms.Button();
            this.button_ResetB = new System.Windows.Forms.Button();
            this.button_tomap = new System.Windows.Forms.Button();
            this.button_retry = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_hint = new System.Windows.Forms.Button();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.listBox_options = new System.Windows.Forms.ListBox();
            this.listBox_A = new System.Windows.Forms.ListBox();
            this.listBox_B = new System.Windows.Forms.ListBox();
            this.listBox_ABoptions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(72, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 480);
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
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_start.Font = new System.Drawing.Font("游明朝 Demibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_start.ForeColor = System.Drawing.Color.Navy;
            this.button_start.Location = new System.Drawing.Point(1291, 621);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(223, 100);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "出発！";
            this.button_start.UseVisualStyleBackColor = false;
            // 
            // button_ResetInput
            // 
            this.button_ResetInput.Location = new System.Drawing.Point(783, 97);
            this.button_ResetInput.Name = "button_ResetInput";
            this.button_ResetInput.Size = new System.Drawing.Size(54, 24);
            this.button_ResetInput.TabIndex = 4;
            this.button_ResetInput.Text = "リセット";
            this.button_ResetInput.UseVisualStyleBackColor = true;
            // 
            // button_ResetA
            // 
            this.button_ResetA.Location = new System.Drawing.Point(1038, 97);
            this.button_ResetA.Name = "button_ResetA";
            this.button_ResetA.Size = new System.Drawing.Size(54, 24);
            this.button_ResetA.TabIndex = 5;
            this.button_ResetA.Text = "リセット";
            this.button_ResetA.UseVisualStyleBackColor = true;
            // 
            // button_ResetB
            // 
            this.button_ResetB.Location = new System.Drawing.Point(1291, 97);
            this.button_ResetB.Name = "button_ResetB";
            this.button_ResetB.Size = new System.Drawing.Size(54, 24);
            this.button_ResetB.TabIndex = 6;
            this.button_ResetB.Text = "リセット";
            this.button_ResetB.UseVisualStyleBackColor = true;
            // 
            // button_tomap
            // 
            this.button_tomap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_tomap.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_tomap.ForeColor = System.Drawing.Color.White;
            this.button_tomap.Location = new System.Drawing.Point(1335, 9);
            this.button_tomap.Name = "button_tomap";
            this.button_tomap.Size = new System.Drawing.Size(158, 46);
            this.button_tomap.TabIndex = 7;
            this.button_tomap.Text = "マップに戻る";
            this.button_tomap.UseVisualStyleBackColor = false;
            // 
            // button_retry
            // 
            this.button_retry.BackColor = System.Drawing.Color.Tomato;
            this.button_retry.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_retry.ForeColor = System.Drawing.Color.White;
            this.button_retry.Location = new System.Drawing.Point(1184, 724);
            this.button_retry.Name = "button_retry";
            this.button_retry.Size = new System.Drawing.Size(223, 50);
            this.button_retry.TabIndex = 8;
            this.button_retry.Text = "リトライ！";
            this.button_retry.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1550, 821);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 82);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button_hint
            // 
            this.button_hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_hint.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_hint.ForeColor = System.Drawing.Color.Black;
            this.button_hint.Location = new System.Drawing.Point(923, 685);
            this.button_hint.Name = "button_hint";
            this.button_hint.Size = new System.Drawing.Size(132, 89);
            this.button_hint.TabIndex = 10;
            this.button_hint.Text = "ヒント！";
            this.button_hint.UseVisualStyleBackColor = false;
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_Input.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 35;
            this.listBox_Input.Location = new System.Drawing.Point(783, 127);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(241, 144);
            this.listBox_Input.TabIndex = 11;
            // 
            // listBox_options
            // 
            this.listBox_options.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_options.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_options.FormattingEnabled = true;
            this.listBox_options.ItemHeight = 35;
            this.listBox_options.Location = new System.Drawing.Point(1038, 401);
            this.listBox_options.Name = "listBox_options";
            this.listBox_options.Size = new System.Drawing.Size(241, 144);
            this.listBox_options.TabIndex = 12;
            // 
            // listBox_A
            // 
            this.listBox_A.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_A.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_A.FormattingEnabled = true;
            this.listBox_A.ItemHeight = 35;
            this.listBox_A.Location = new System.Drawing.Point(1038, 127);
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
            this.listBox_B.Location = new System.Drawing.Point(1291, 127);
            this.listBox_B.Name = "listBox_B";
            this.listBox_B.Size = new System.Drawing.Size(241, 144);
            this.listBox_B.TabIndex = 14;
            // 
            // listBox_ABoptions
            // 
            this.listBox_ABoptions.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_ABoptions.Font = new System.Drawing.Font("游明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_ABoptions.FormattingEnabled = true;
            this.listBox_ABoptions.ItemHeight = 35;
            this.listBox_ABoptions.Location = new System.Drawing.Point(1291, 401);
            this.listBox_ABoptions.Name = "listBox_ABoptions";
            this.listBox_ABoptions.Size = new System.Drawing.Size(143, 39);
            this.listBox_ABoptions.TabIndex = 15;
            // 
            // Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1829, 931);
            this.Controls.Add(this.listBox_ABoptions);
            this.Controls.Add(this.listBox_B);
            this.Controls.Add(this.listBox_A);
            this.Controls.Add(this.listBox_options);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.button_hint);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_retry);
            this.Controls.Add(this.button_tomap);
            this.Controls.Add(this.button_ResetB);
            this.Controls.Add(this.button_ResetA);
            this.Controls.Add(this.button_ResetInput);
            this.Controls.Add(this.button_start);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_ResetInput;
        private System.Windows.Forms.Button button_ResetA;
        private System.Windows.Forms.Button button_ResetB;
        private System.Windows.Forms.Button button_tomap;
        private System.Windows.Forms.Button button_retry;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_hint;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.ListBox listBox_options;
        private System.Windows.Forms.ListBox listBox_A;
        private System.Windows.Forms.ListBox listBox_B;
        private System.Windows.Forms.ListBox listBox_ABoptions;
    }
}