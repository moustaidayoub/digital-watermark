namespace Tatouer
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.savebtn = new System.Windows.Forms.Button();
            this.tatouerbtn = new System.Windows.Forms.Button();
            this.textarea = new System.Windows.Forms.RichTextBox();
            this.Ouvrirbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extrairebtn = new System.Windows.Forms.Button();
            this.textarea2 = new System.Windows.Forms.RichTextBox();
            this.ouvrirbtn2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.savebtn);
            this.tabPage1.Controls.Add(this.tatouerbtn);
            this.tabPage1.Controls.Add(this.textarea);
            this.tabPage1.Controls.Add(this.Ouvrirbtn);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tatouer...";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(380, 158);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(160, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Enregistrer Image";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // tatouerbtn
            // 
            this.tatouerbtn.Location = new System.Drawing.Point(576, 58);
            this.tatouerbtn.Name = "tatouerbtn";
            this.tatouerbtn.Size = new System.Drawing.Size(75, 61);
            this.tatouerbtn.TabIndex = 3;
            this.tatouerbtn.Text = "Tatouer image";
            this.tatouerbtn.UseVisualStyleBackColor = true;
            this.tatouerbtn.Click += new System.EventHandler(this.tatouerbtn_Click);
            // 
            // textarea
            // 
            this.textarea.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textarea.Location = new System.Drawing.Point(341, 42);
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(229, 93);
            this.textarea.TabIndex = 2;
            this.textarea.Text = "Alphabet [a-z] ou espace seulement acceptés && nombre caracteres max = 600 caract" +
    "ere";
            // 
            // Ouvrirbtn
            // 
            this.Ouvrirbtn.Location = new System.Drawing.Point(89, 13);
            this.Ouvrirbtn.Name = "Ouvrirbtn";
            this.Ouvrirbtn.Size = new System.Drawing.Size(151, 23);
            this.Ouvrirbtn.TabIndex = 1;
            this.Ouvrirbtn.Text = "Ouvrir Image (300x200)";
            this.Ouvrirbtn.UseVisualStyleBackColor = true;
            this.Ouvrirbtn.Click += new System.EventHandler(this.Ouvrirbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.extrairebtn);
            this.tabPage2.Controls.Add(this.textarea2);
            this.tabPage2.Controls.Add(this.ouvrirbtn2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extraire...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // extrairebtn
            // 
            this.extrairebtn.Location = new System.Drawing.Point(451, 42);
            this.extrairebtn.Name = "extrairebtn";
            this.extrairebtn.Size = new System.Drawing.Size(75, 23);
            this.extrairebtn.TabIndex = 4;
            this.extrairebtn.Text = "Extraire ";
            this.extrairebtn.UseVisualStyleBackColor = true;
            this.extrairebtn.Click += new System.EventHandler(this.extrairebtn_Click);
            // 
            // textarea2
            // 
            this.textarea2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textarea2.Location = new System.Drawing.Point(339, 71);
            this.textarea2.Name = "textarea2";
            this.textarea2.Size = new System.Drawing.Size(310, 123);
            this.textarea2.TabIndex = 3;
            this.textarea2.Text = "";
            // 
            // ouvrirbtn2
            // 
            this.ouvrirbtn2.Location = new System.Drawing.Point(89, 13);
            this.ouvrirbtn2.Name = "ouvrirbtn2";
            this.ouvrirbtn2.Size = new System.Drawing.Size(151, 23);
            this.ouvrirbtn2.TabIndex = 2;
            this.ouvrirbtn2.Text = "Ouvrir Image (Tatouée)";
            this.ouvrirbtn2.UseVisualStyleBackColor = true;
            this.ouvrirbtn2.Click += new System.EventHandler(this.ouvrirbtn2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Tatouage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Ouvrirbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button tatouerbtn;
        private System.Windows.Forms.RichTextBox textarea;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button extrairebtn;
        private System.Windows.Forms.RichTextBox textarea2;
        private System.Windows.Forms.Button ouvrirbtn2;
    }
}

