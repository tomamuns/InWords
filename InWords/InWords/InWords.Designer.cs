namespace InWords
{
    partial class InWordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InWordsForm));
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inWordsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maleVoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleVoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.banglaDisplayButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(165, 32);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(237, 20);
            this.numberTextBox.TabIndex = 0;
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(165, 64);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(246, 64);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Number (up to 14 digits)";
            // 
            // inWordsTextBox
            // 
            this.inWordsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inWordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inWordsTextBox.Location = new System.Drawing.Point(165, 122);
            this.inWordsTextBox.Multiline = true;
            this.inWordsTextBox.Name = "inWordsTextBox";
            this.inWordsTextBox.ReadOnly = true;
            this.inWordsTextBox.Size = new System.Drawing.Size(501, 66);
            this.inWordsTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number In Words";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(327, 64);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maleVoiceRadioButton);
            this.groupBox1.Controls.Add(this.femaleVoiceRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(422, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice";
            // 
            // maleVoiceRadioButton
            // 
            this.maleVoiceRadioButton.AutoSize = true;
            this.maleVoiceRadioButton.Location = new System.Drawing.Point(6, 26);
            this.maleVoiceRadioButton.Name = "maleVoiceRadioButton";
            this.maleVoiceRadioButton.Size = new System.Drawing.Size(52, 17);
            this.maleVoiceRadioButton.TabIndex = 6;
            this.maleVoiceRadioButton.TabStop = true;
            this.maleVoiceRadioButton.Text = "Male";
            this.maleVoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleVoiceRadioButton
            // 
            this.femaleVoiceRadioButton.AutoSize = true;
            this.femaleVoiceRadioButton.Checked = true;
            this.femaleVoiceRadioButton.Location = new System.Drawing.Point(82, 26);
            this.femaleVoiceRadioButton.Name = "femaleVoiceRadioButton";
            this.femaleVoiceRadioButton.Size = new System.Drawing.Size(65, 17);
            this.femaleVoiceRadioButton.TabIndex = 5;
            this.femaleVoiceRadioButton.TabStop = true;
            this.femaleVoiceRadioButton.Text = "Female";
            this.femaleVoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // banglaDisplayButton
            // 
            this.banglaDisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banglaDisplayButton.Location = new System.Drawing.Point(165, 93);
            this.banglaDisplayButton.Name = "banglaDisplayButton";
            this.banglaDisplayButton.Size = new System.Drawing.Size(75, 23);
            this.banglaDisplayButton.TabIndex = 1;
            this.banglaDisplayButton.Text = "বাংলা";
            this.banglaDisplayButton.UseVisualStyleBackColor = true;
            this.banglaDisplayButton.Click += new System.EventHandler(this.banglaDisplayButton_Click);
            // 
            // InWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 213);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.banglaDisplayButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.inWordsTextBox);
            this.Controls.Add(this.numberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InWordsForm";
            this.Text = "In Words v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inWordsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton maleVoiceRadioButton;
        private System.Windows.Forms.RadioButton femaleVoiceRadioButton;
        private System.Windows.Forms.Button banglaDisplayButton;
    }
}

