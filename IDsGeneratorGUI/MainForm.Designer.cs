namespace IDsGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonGenerateListfile = new System.Windows.Forms.Button();
            this.buttonGeneratePatch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateListfile
            // 
            this.buttonGenerateListfile.Location = new System.Drawing.Point(12, 146);
            this.buttonGenerateListfile.Name = "buttonGenerateListfile";
            this.buttonGenerateListfile.Size = new System.Drawing.Size(102, 37);
            this.buttonGenerateListfile.TabIndex = 0;
            this.buttonGenerateListfile.Text = "Generate listfile";
            this.buttonGenerateListfile.UseVisualStyleBackColor = true;
            this.buttonGenerateListfile.Click += new System.EventHandler(this.buttonGenerateListfile_Click);
            // 
            // buttonGeneratePatch
            // 
            this.buttonGeneratePatch.Location = new System.Drawing.Point(262, 146);
            this.buttonGeneratePatch.Name = "buttonGeneratePatch";
            this.buttonGeneratePatch.Size = new System.Drawing.Size(102, 37);
            this.buttonGeneratePatch.TabIndex = 1;
            this.buttonGeneratePatch.Text = "Generate patch";
            this.buttonGeneratePatch.UseVisualStyleBackColor = true;
            this.buttonGeneratePatch.Click += new System.EventHandler(this.buttonGeneratePatch_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(37, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(297, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initial ID";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(37, 89);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(297, 20);
            this.textBoxPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to files";
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(340, 89);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(22, 19);
            this.buttonFindPath.TabIndex = 6;
            this.buttonFindPath.Text = "...";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.buttonFindPath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 206);
            this.Controls.Add(this.buttonFindPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonGeneratePatch);
            this.Controls.Add(this.buttonGenerateListfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "IDs Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateListfile;
        private System.Windows.Forms.Button buttonGeneratePatch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindPath;
    }
}

