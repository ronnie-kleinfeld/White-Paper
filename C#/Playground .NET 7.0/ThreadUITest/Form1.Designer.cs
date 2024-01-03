namespace ThreadUITest
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
            buttonUIPlus1 = new Button();
            textBoxUI = new TextBox();
            buttonUIMinus1 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxFunctionInThread = new TextBox();
            textBoxReadJsonFile = new TextBox();
            button5 = new Button();
            textBoxDownloadBigFile = new TextBox();
            textBoxDownloadBigFileAsync = new TextBox();
            button6 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUIPlus1
            // 
            buttonUIPlus1.Location = new Point(6, 38);
            buttonUIPlus1.Name = "buttonUIPlus1";
            buttonUIPlus1.Size = new Size(150, 46);
            buttonUIPlus1.TabIndex = 0;
            buttonUIPlus1.Text = "+";
            buttonUIPlus1.UseVisualStyleBackColor = true;
            buttonUIPlus1.Click += uiPlus1_Click;
            // 
            // textBoxUI
            // 
            textBoxUI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUI.Location = new Point(162, 68);
            textBoxUI.Name = "textBoxUI";
            textBoxUI.Size = new Size(474, 39);
            textBoxUI.TabIndex = 1;
            // 
            // buttonUIMinus1
            // 
            buttonUIMinus1.Location = new Point(6, 90);
            buttonUIMinus1.Name = "buttonUIMinus1";
            buttonUIMinus1.Size = new Size(150, 46);
            buttonUIMinus1.TabIndex = 2;
            buttonUIMinus1.Text = "-";
            buttonUIMinus1.UseVisualStyleBackColor = true;
            buttonUIMinus1.Click += uiMinus1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 38);
            button3.Name = "button3";
            button3.Size = new Size(150, 120);
            button3.TabIndex = 3;
            button3.Text = "Function In Thread";
            button3.UseVisualStyleBackColor = true;
            button3.Click += functionInThread_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 38);
            button4.Name = "button4";
            button4.Size = new Size(150, 120);
            button4.TabIndex = 4;
            button4.Text = "Async";
            button4.UseVisualStyleBackColor = true;
            button4.Click += asyncReadJsonFile_Click;
            // 
            // textBoxFunctionInThread
            // 
            textBoxFunctionInThread.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFunctionInThread.Location = new Point(162, 38);
            textBoxFunctionInThread.Multiline = true;
            textBoxFunctionInThread.Name = "textBoxFunctionInThread";
            textBoxFunctionInThread.Size = new Size(458, 120);
            textBoxFunctionInThread.TabIndex = 5;
            // 
            // textBoxReadJsonFile
            // 
            textBoxReadJsonFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReadJsonFile.Location = new Point(162, 38);
            textBoxReadJsonFile.Multiline = true;
            textBoxReadJsonFile.Name = "textBoxReadJsonFile";
            textBoxReadJsonFile.Size = new Size(452, 120);
            textBoxReadJsonFile.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(20, 38);
            button5.Name = "button5";
            button5.Size = new Size(150, 120);
            button5.TabIndex = 7;
            button5.Text = "Just a Function";
            button5.UseVisualStyleBackColor = true;
            button5.Click += donwloadBigFile_Click;
            // 
            // textBoxDownloadBigFile
            // 
            textBoxDownloadBigFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDownloadBigFile.Location = new Point(176, 38);
            textBoxDownloadBigFile.Multiline = true;
            textBoxDownloadBigFile.Name = "textBoxDownloadBigFile";
            textBoxDownloadBigFile.Size = new Size(433, 120);
            textBoxDownloadBigFile.TabIndex = 8;
            // 
            // textBoxDownloadBigFileAsync
            // 
            textBoxDownloadBigFileAsync.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDownloadBigFileAsync.Location = new Point(176, 164);
            textBoxDownloadBigFileAsync.Multiline = true;
            textBoxDownloadBigFileAsync.Name = "textBoxDownloadBigFileAsync";
            textBoxDownloadBigFileAsync.Size = new Size(433, 120);
            textBoxDownloadBigFileAsync.TabIndex = 10;
            // 
            // button6
            // 
            button6.Location = new Point(20, 164);
            button6.Name = "button6";
            button6.Size = new Size(150, 120);
            button6.TabIndex = 9;
            button6.Text = "async Task Function";
            button6.UseVisualStyleBackColor = true;
            button6.Click += downloadBigFileAsync_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonUIPlus1);
            groupBox1.Controls.Add(textBoxUI);
            groupBox1.Controls.Add(buttonUIMinus1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 149);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "UI Elements";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBoxFunctionInThread);
            groupBox2.Location = new Point(12, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(642, 191);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Function in a Thread";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBoxReadJsonFile);
            groupBox3.Location = new Point(12, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(642, 189);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Async read json file";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxDownloadBigFile);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(textBoxDownloadBigFileAsync);
            groupBox4.Location = new Point(12, 559);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(642, 311);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mosh - Download big file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 907);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUIPlus1;
        private TextBox textBoxUI;
        private Button buttonUIMinus1;
        private Button button3;
        private Button button4;
        private TextBox textBoxFunctionInThread;
        private TextBox textBoxReadJsonFile;
        private Button button5;
        private TextBox textBoxDownloadBigFile;
        private TextBox textBoxDownloadBigFileAsync;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
