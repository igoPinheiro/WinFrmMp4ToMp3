namespace WinFrmMp4ToMp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnSearch = new Button();
            btnSave = new Button();
            btnConvert = new Button();
            toolTipSave = new ToolTip(components);
            toolTipSearch = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Origem Video:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Salvar Em:";
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.White;
            txtInput.Location = new Point(12, 27);
            txtInput.Name = "txtInput";
            txtInput.ReadOnly = true;
            txtInput.Size = new Size(778, 23);
            txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.White;
            txtOutput.Location = new Point(12, 82);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(778, 23);
            txtOutput.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(12, 121);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Procurar Video";
            toolTipSearch.SetToolTip(btnSearch, " ");
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(164, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Salvar";
            toolTipSave.SetToolTip(btnSave, " ");
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(316, 121);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(169, 23);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Converter";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // toolTipSave
            // 
            toolTipSave.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave.ToolTipTitle = "Selecione o caminho onde o mp3 será salvo.";
            // 
            // toolTipSearch
            // 
            toolTipSearch.Tag = "";
            toolTipSearch.ToolTipIcon = ToolTipIcon.Info;
            toolTipSearch.ToolTipTitle = "Selecione o arquivo mp4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 163);
            Controls.Add(btnConvert);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(818, 202);
            MinimumSize = new Size(818, 202);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mp4 To Mp3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnSearch;
        private Button btnSave;
        private Button btnConvert;
        private ToolTip toolTipSave;
        private ToolTip toolTipSearch;
    }
}