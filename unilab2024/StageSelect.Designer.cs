namespace unilab2024
{
    partial class StageSelect
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
            this.labelWorld = new System.Windows.Forms.Label();
            this.buttonToMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWorld
            // 
            this.labelWorld.AutoSize = true;
            this.labelWorld.Font = new System.Drawing.Font("游明朝 Demibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWorld.Location = new System.Drawing.Point(660, 150);
            this.labelWorld.Name = "labelWorld";
            this.labelWorld.Size = new System.Drawing.Size(383, 83);
            this.labelWorld.TabIndex = 0;
            this.labelWorld.Text = "WorldName";
            // 
            // buttonToMap
            // 
            this.buttonToMap.BackColor = System.Drawing.Color.Gray;
            this.buttonToMap.Font = new System.Drawing.Font("游明朝 Demibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonToMap.ForeColor = System.Drawing.Color.White;
            this.buttonToMap.Location = new System.Drawing.Point(1350, 10);
            this.buttonToMap.Name = "buttonToMap";
            this.buttonToMap.Size = new System.Drawing.Size(160, 50);
            this.buttonToMap.TabIndex = 1;
            this.buttonToMap.Text = "学年選択に戻る";
            this.buttonToMap.UseVisualStyleBackColor = false;
            this.buttonToMap.Click += new System.EventHandler(this.buttonToMap_Click);
            // 
            // StageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 931);
            this.Controls.Add(this.buttonToMap);
            this.Controls.Add(this.labelWorld);
            this.Name = "StageSelect";
            this.Text = "StageSelect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StageSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorld;
        private System.Windows.Forms.Button buttonToMap;
    }
}