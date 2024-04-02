namespace DigimonAndTamerCharacterSheets
{
    partial class Form2
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
            this.BasicSkillGain = new System.Windows.Forms.ComboBox();
            this.SuperSkillGain = new System.Windows.Forms.ComboBox();
            this.LevelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BasicSkillGain
            // 
            this.BasicSkillGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicSkillGain.FormattingEnabled = true;
            this.BasicSkillGain.Items.AddRange(new object[] {
            "Carry",
            "Throw",
            "Hold",
            "Balance",
            "Parkour",
            "Reflex",
            "Perform",
            "Intimidate",
            "Persuade",
            "Investigation",
            "Empathy",
            "Ingenuity",
            "Technology",
            "Occultism",
            "Society"});
            this.BasicSkillGain.Location = new System.Drawing.Point(39, 291);
            this.BasicSkillGain.Name = "BasicSkillGain";
            this.BasicSkillGain.Size = new System.Drawing.Size(211, 33);
            this.BasicSkillGain.TabIndex = 0;
            // 
            // SuperSkillGain
            // 
            this.SuperSkillGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperSkillGain.FormattingEnabled = true;
            this.SuperSkillGain.Items.AddRange(new object[] {
            "Error Scan",
            "Info Extract",
            "Giga Search",
            "Wayback Track"});
            this.SuperSkillGain.Location = new System.Drawing.Point(548, 291);
            this.SuperSkillGain.Name = "SuperSkillGain";
            this.SuperSkillGain.Size = new System.Drawing.Size(211, 33);
            this.SuperSkillGain.TabIndex = 1;
            // 
            // LevelButton
            // 
            this.LevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LevelButton.Location = new System.Drawing.Point(312, 390);
            this.LevelButton.Name = "LevelButton";
            this.LevelButton.Size = new System.Drawing.Size(164, 33);
            this.LevelButton.TabIndex = 2;
            this.LevelButton.Text = "Apply Level Up";
            this.LevelButton.UseVisualStyleBackColor = true;
            this.LevelButton.Click += new System.EventHandler(this.LevelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(87, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Basic Skills";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(593, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Super Skills";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LevelButton);
            this.Controls.Add(this.SuperSkillGain);
            this.Controls.Add(this.BasicSkillGain);
            this.Name = "Form2";
            this.Text = "Level Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BasicSkillGain;
        private System.Windows.Forms.ComboBox SuperSkillGain;
        private System.Windows.Forms.Button LevelButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}