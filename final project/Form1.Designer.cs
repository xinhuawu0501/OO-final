namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pinBoardPropsGroup = new System.Windows.Forms.GroupBox();
            this.pinBoardVisualGroup = new System.Windows.Forms.GroupBox();
            this.coordGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.xIntervalBox = new System.Windows.Forms.TextBox();
            this.yIntervalBox = new System.Windows.Forms.TextBox();
            this.colBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptRowLabel = new System.Windows.Forms.Label();
            this.ptColLabel = new System.Windows.Forms.Label();
            this.ptYLabel = new System.Windows.Forms.Label();
            this.ptXLabel = new System.Windows.Forms.Label();
            this.createPinBoardBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.pinBoardPropsGroup.SuspendLayout();
            this.coordGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pinBoardPropsGroup
            // 
            this.pinBoardPropsGroup.Controls.Add(this.createPinBoardBtn);
            this.pinBoardPropsGroup.Controls.Add(this.yIntervalBox);
            this.pinBoardPropsGroup.Controls.Add(this.colBox);
            this.pinBoardPropsGroup.Controls.Add(this.label3);
            this.pinBoardPropsGroup.Controls.Add(this.label4);
            this.pinBoardPropsGroup.Controls.Add(this.xIntervalBox);
            this.pinBoardPropsGroup.Controls.Add(this.rowBox);
            this.pinBoardPropsGroup.Controls.Add(this.label2);
            this.pinBoardPropsGroup.Controls.Add(this.label1);
            this.pinBoardPropsGroup.Location = new System.Drawing.Point(12, 21);
            this.pinBoardPropsGroup.Name = "pinBoardPropsGroup";
            this.pinBoardPropsGroup.Size = new System.Drawing.Size(366, 194);
            this.pinBoardPropsGroup.TabIndex = 0;
            this.pinBoardPropsGroup.TabStop = false;
            this.pinBoardPropsGroup.Text = "Properties of PinBoard";
            // 
            // pinBoardVisualGroup
            // 
            this.pinBoardVisualGroup.Location = new System.Drawing.Point(384, 21);
            this.pinBoardVisualGroup.Name = "pinBoardVisualGroup";
            this.pinBoardVisualGroup.Size = new System.Drawing.Size(444, 264);
            this.pinBoardVisualGroup.TabIndex = 1;
            this.pinBoardVisualGroup.TabStop = false;
            this.pinBoardVisualGroup.Text = "Visualization of PinBoard";
            // 
            // coordGroup
            // 
            this.coordGroup.Controls.Add(this.calcBtn);
            this.coordGroup.Controls.Add(this.ptYLabel);
            this.coordGroup.Controls.Add(this.ptXLabel);
            this.coordGroup.Controls.Add(this.ptColLabel);
            this.coordGroup.Controls.Add(this.ptRowLabel);
            this.coordGroup.Location = new System.Drawing.Point(12, 235);
            this.coordGroup.Name = "coordGroup";
            this.coordGroup.Size = new System.Drawing.Size(366, 233);
            this.coordGroup.TabIndex = 1;
            this.coordGroup.TabStop = false;
            this.coordGroup.Text = "Coordinates of Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "XInterval";
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(71, 60);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(100, 22);
            this.rowBox.TabIndex = 2;
            // 
            // xIntervalBox
            // 
            this.xIntervalBox.Location = new System.Drawing.Point(71, 115);
            this.xIntervalBox.Name = "xIntervalBox";
            this.xIntervalBox.Size = new System.Drawing.Size(100, 22);
            this.xIntervalBox.TabIndex = 3;
            // 
            // yIntervalBox
            // 
            this.yIntervalBox.Location = new System.Drawing.Point(232, 115);
            this.yIntervalBox.Name = "yIntervalBox";
            this.yIntervalBox.Size = new System.Drawing.Size(100, 22);
            this.yIntervalBox.TabIndex = 7;
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(232, 60);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(100, 22);
            this.colBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 120);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "YInterval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cols";
            // 
            // ptRowLabel
            // 
            this.ptRowLabel.AutoSize = true;
            this.ptRowLabel.Location = new System.Drawing.Point(32, 38);
            this.ptRowLabel.Name = "ptRowLabel";
            this.ptRowLabel.Size = new System.Drawing.Size(27, 12);
            this.ptRowLabel.TabIndex = 8;
            this.ptRowLabel.Text = "Row";
            // 
            // ptColLabel
            // 
            this.ptColLabel.AutoSize = true;
            this.ptColLabel.Location = new System.Drawing.Point(120, 38);
            this.ptColLabel.Name = "ptColLabel";
            this.ptColLabel.Size = new System.Drawing.Size(22, 12);
            this.ptColLabel.TabIndex = 9;
            this.ptColLabel.Text = "Col";
            // 
            // ptYLabel
            // 
            this.ptYLabel.AutoSize = true;
            this.ptYLabel.Location = new System.Drawing.Point(285, 38);
            this.ptYLabel.Name = "ptYLabel";
            this.ptYLabel.Size = new System.Drawing.Size(13, 12);
            this.ptYLabel.TabIndex = 11;
            this.ptYLabel.Text = "Y";
            // 
            // ptXLabel
            // 
            this.ptXLabel.AutoSize = true;
            this.ptXLabel.Location = new System.Drawing.Point(197, 38);
            this.ptXLabel.Name = "ptXLabel";
            this.ptXLabel.Size = new System.Drawing.Size(13, 12);
            this.ptXLabel.TabIndex = 10;
            this.ptXLabel.Text = "X";
            // 
            // createPinBoardBtn
            // 
            this.createPinBoardBtn.Location = new System.Drawing.Point(232, 155);
            this.createPinBoardBtn.Name = "createPinBoardBtn";
            this.createPinBoardBtn.Size = new System.Drawing.Size(117, 23);
            this.createPinBoardBtn.TabIndex = 8;
            this.createPinBoardBtn.Text = "Create PinBoard";
            this.createPinBoardBtn.UseVisualStyleBackColor = true;
            this.createPinBoardBtn.Click += new System.EventHandler(this.createPinBoardBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(274, 204);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 9;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(384, 291);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(744, 454);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(384, 320);
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.messageBox.Size = new System.Drawing.Size(354, 171);
            this.messageBox.TabIndex = 14;
            this.messageBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 503);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.coordGroup);
            this.Controls.Add(this.pinBoardVisualGroup);
            this.Controls.Add(this.pinBoardPropsGroup);
            this.Name = "Form1";
            this.Text = "114 Final";
            this.pinBoardPropsGroup.ResumeLayout(false);
            this.pinBoardPropsGroup.PerformLayout();
            this.coordGroup.ResumeLayout(false);
            this.coordGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pinBoardPropsGroup;
        private System.Windows.Forms.TextBox yIntervalBox;
        private System.Windows.Forms.TextBox colBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xIntervalBox;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pinBoardVisualGroup;
        private System.Windows.Forms.GroupBox coordGroup;
        private System.Windows.Forms.Label ptRowLabel;
        private System.Windows.Forms.Button createPinBoardBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label ptYLabel;
        private System.Windows.Forms.Label ptXLabel;
        private System.Windows.Forms.Label ptColLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RichTextBox messageBox;
    }
}

