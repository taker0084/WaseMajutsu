namespace unilab2024
{
    partial class Prologue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prologue));
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.button_Girl = new unilab2024.CustomButton();
            this.button_Boy = new unilab2024.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Background
            // 
            this.pictureBox_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Background.BackgroundImage")));
            this.pictureBox_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Background.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_Background.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Background.Name = "pictureBox_Background";
            this.pictureBox_Background.Size = new System.Drawing.Size(1536, 900);
            this.pictureBox_Background.TabIndex = 1;
            this.pictureBox_Background.TabStop = false;
            // 
            // button_Girl
            // 
            this.button_Girl.ConditionImage = null;
            this.button_Girl.ForeImage = null;
            this.button_Girl.Location = new System.Drawing.Point(886, 250);
            this.button_Girl.Name = "button_Girl";
            this.button_Girl.Size = new System.Drawing.Size(400, 400);
            this.button_Girl.TabIndex = 3;
            this.button_Girl.UseVisualStyleBackColor = true;
            this.button_Girl.Click += new System.EventHandler(this.button_CharaSelect_Click);
            // 
            // button_Boy
            // 
            this.button_Boy.ConditionImage = null;
            this.button_Boy.ForeImage = null;
            this.button_Boy.Location = new System.Drawing.Point(250, 250);
            this.button_Boy.Name = "button_Boy";
            this.button_Boy.Size = new System.Drawing.Size(400, 400);
            this.button_Boy.TabIndex = 2;
            this.button_Boy.UseVisualStyleBackColor = true;
            this.button_Boy.Click += new System.EventHandler(this.button_CharaSelect_Click);
            // 
            // Prologue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 861);
            this.Controls.Add(this.button_Girl);
            this.Controls.Add(this.button_Boy);
            this.Controls.Add(this.pictureBox_Background);
            this.Name = "Prologue";
            this.Text = "Prologue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prologue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private CustomButton button_Boy;
        private CustomButton button_Girl;
    }
}