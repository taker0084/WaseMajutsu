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
            this.buttonToMap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Boy = new unilab2024.CustomButton();
            this.button_Girl = new unilab2024.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToMap
            // 
            this.buttonToMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToMap.Font = new System.Drawing.Font("游明朝 Demibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonToMap.Location = new System.Drawing.Point(1280, 800);
            this.buttonToMap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToMap.Name = "buttonToMap";
            this.buttonToMap.Size = new System.Drawing.Size(250, 80);
            this.buttonToMap.TabIndex = 0;
            this.buttonToMap.Text = "WorldMapへ";
            this.buttonToMap.UseVisualStyleBackColor = true;
            this.buttonToMap.Click += new System.EventHandler(this.buttonToMap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 900);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Boy
            // 
            this.button_Boy.ForeImage = null;
            this.button_Boy.Location = new System.Drawing.Point(250, 250);
            this.button_Boy.Name = "button_Boy";
            this.button_Boy.Size = new System.Drawing.Size(400, 400);
            this.button_Boy.TabIndex = 2;
            this.button_Boy.UseVisualStyleBackColor = true;
            this.button_Boy.Click += new System.EventHandler(this.button_CharaSelect_Click);
            // 
            // button_Girl
            // 
            this.button_Girl.ForeImage = null;
            this.button_Girl.Location = new System.Drawing.Point(886, 250);
            this.button_Girl.Name = "button_Girl";
            this.button_Girl.Size = new System.Drawing.Size(400, 400);
            this.button_Girl.TabIndex = 3;
            this.button_Girl.UseVisualStyleBackColor = true;
            this.button_Girl.Click += new System.EventHandler(this.button_CharaSelect_Click);
            // 
            // Prologue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 861);
            this.Controls.Add(this.button_Girl);
            this.Controls.Add(this.button_Boy);
            this.Controls.Add(this.buttonToMap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Prologue";
            this.Text = "Prologue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prologue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton button_Boy;
        private CustomButton button_Girl;
    }
}