
namespace GorselProgramlamaFinal3
{
    partial class LZWTestForm
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.compressbutton = new System.Windows.Forms.Button();
            this.decompressbutton = new System.Windows.Forms.Button();
            this.selectfilebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.lempelZivWelchComponent1 = new GorselProgramlamaFinal3.LempelZivWelchComponent(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 129);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(52, 205);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(366, 129);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // compressbutton
            // 
            this.compressbutton.Location = new System.Drawing.Point(176, 162);
            this.compressbutton.Name = "compressbutton";
            this.compressbutton.Size = new System.Drawing.Size(118, 37);
            this.compressbutton.TabIndex = 2;
            this.compressbutton.Text = "Compress";
            this.compressbutton.UseVisualStyleBackColor = true;
            this.compressbutton.Click += new System.EventHandler(this.compressbutton_Click);
            // 
            // decompressbutton
            // 
            this.decompressbutton.Location = new System.Drawing.Point(300, 162);
            this.decompressbutton.Name = "decompressbutton";
            this.decompressbutton.Size = new System.Drawing.Size(118, 37);
            this.decompressbutton.TabIndex = 3;
            this.decompressbutton.Text = "DeCompress";
            this.decompressbutton.UseVisualStyleBackColor = true;
            this.decompressbutton.Click += new System.EventHandler(this.decompressbutton_Click);
            // 
            // selectfilebutton
            // 
            this.selectfilebutton.Location = new System.Drawing.Point(52, 162);
            this.selectfilebutton.Name = "selectfilebutton";
            this.selectfilebutton.Size = new System.Drawing.Size(118, 37);
            this.selectfilebutton.TabIndex = 4;
            this.selectfilebutton.Text = "Select File";
            this.selectfilebutton.UseVisualStyleBackColor = true;
            this.selectfilebutton.Click += new System.EventHandler(this.selectfilebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(300, 340);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(118, 37);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // LZWTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 410);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.selectfilebutton);
            this.Controls.Add(this.decompressbutton);
            this.Controls.Add(this.compressbutton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "LZWTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button compressbutton;
        private System.Windows.Forms.Button decompressbutton;
        private System.Windows.Forms.Button selectfilebutton;
        private System.Windows.Forms.Button savebutton;
        private LempelZivWelchComponent lempelZivWelchComponent1;
    }
}

