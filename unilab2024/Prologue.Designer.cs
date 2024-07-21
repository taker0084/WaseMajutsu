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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_CharaName = new System.Windows.Forms.PictureBox();
            this.pictureBox_CharaImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_Dialogue = new System.Windows.Forms.PictureBox();
            this.button_Girl = new unilab2024.CustomButton();
            this.button_Boy = new unilab2024.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CharaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CharaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dialogue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 900);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_CharaName
            // 
            this.pictureBox_CharaName.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CharaName.Location = new System.Drawing.Point(15, 600);
            this.pictureBox_CharaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_CharaName.Name = "pictureBox_CharaName";
            this.pictureBox_CharaName.Size = new System.Drawing.Size(300, 60);
            this.pictureBox_CharaName.TabIndex = 38;
            this.pictureBox_CharaName.TabStop = false;
            // 
            // pictureBox_CharaImage
            // 
            this.pictureBox_CharaImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CharaImage.Location = new System.Drawing.Point(15, 300);
            this.pictureBox_CharaImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_CharaImage.Name = "pictureBox_CharaImage";
            this.pictureBox_CharaImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_CharaImage.TabIndex = 39;
            this.pictureBox_CharaImage.TabStop = false;
            // 
            // pictureBox_Dialogue
            // 
            this.pictureBox_Dialogue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Dialogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Dialogue.Location = new System.Drawing.Point(15, 660);
            this.pictureBox_Dialogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Dialogue.Name = "pictureBox_Dialogue";
            this.pictureBox_Dialogue.Size = new System.Drawing.Size(1500, 200);
            this.pictureBox_Dialogue.TabIndex = 40;
            this.pictureBox_Dialogue.TabStop = false;
            this.pictureBox_Dialogue.Click += new System.EventHandler(this.pictureBox_Dialogue_Click);
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
            this.Controls.Add(this.pictureBox_Dialogue);
            this.Controls.Add(this.pictureBox_CharaImage);
            this.Controls.Add(this.pictureBox_CharaName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Prologue";
            this.Text = "Prologue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prologue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CharaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CharaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dialogue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton button_Boy;
        private CustomButton button_Girl;
        private System.Windows.Forms.PictureBox pictureBox_CharaName;
        private System.Windows.Forms.PictureBox pictureBox_CharaImage;
        private System.Windows.Forms.PictureBox pictureBox_Dialogue;
    }
}