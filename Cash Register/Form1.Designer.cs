namespace Cash_Register
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
            this.appleInput = new System.Windows.Forms.TextBox();
            this.teslaInput = new System.Windows.Forms.TextBox();
            this.shopifyInput = new System.Windows.Forms.TextBox();
            this.teslaLabel = new System.Windows.Forms.Label();
            this.shopifyLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.appleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.dashsLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appleInput
            // 
            this.appleInput.Location = new System.Drawing.Point(168, 135);
            this.appleInput.Margin = new System.Windows.Forms.Padding(4);
            this.appleInput.Name = "appleInput";
            this.appleInput.Size = new System.Drawing.Size(164, 31);
            this.appleInput.TabIndex = 0;
            this.appleInput.Text = "0";
            // 
            // teslaInput
            // 
            this.teslaInput.Location = new System.Drawing.Point(168, 194);
            this.teslaInput.Margin = new System.Windows.Forms.Padding(4);
            this.teslaInput.Name = "teslaInput";
            this.teslaInput.Size = new System.Drawing.Size(164, 31);
            this.teslaInput.TabIndex = 1;
            this.teslaInput.Text = "0";
            // 
            // shopifyInput
            // 
            this.shopifyInput.Location = new System.Drawing.Point(168, 256);
            this.shopifyInput.Margin = new System.Windows.Forms.Padding(4);
            this.shopifyInput.Name = "shopifyInput";
            this.shopifyInput.Size = new System.Drawing.Size(164, 31);
            this.shopifyInput.TabIndex = 2;
            this.shopifyInput.Text = "0";
            // 
            // teslaLabel
            // 
            this.teslaLabel.AutoSize = true;
            this.teslaLabel.Location = new System.Drawing.Point(92, 198);
            this.teslaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teslaLabel.Name = "teslaLabel";
            this.teslaLabel.Size = new System.Drawing.Size(70, 25);
            this.teslaLabel.TabIndex = 4;
            this.teslaLabel.Text = "Telsla";
            // 
            // shopifyLabel
            // 
            this.shopifyLabel.AutoSize = true;
            this.shopifyLabel.Location = new System.Drawing.Point(80, 258);
            this.shopifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopifyLabel.Name = "shopifyLabel";
            this.shopifyLabel.Size = new System.Drawing.Size(84, 25);
            this.shopifyLabel.TabIndex = 5;
            this.shopifyLabel.Text = "Shopify";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(116, 302);
            this.totalButton.Margin = new System.Windows.Forms.Padding(4);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(254, 67);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Total ";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appleLabel
            // 
            this.appleLabel.AutoSize = true;
            this.appleLabel.Location = new System.Drawing.Point(92, 135);
            this.appleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appleLabel.Name = "appleLabel";
            this.appleLabel.Size = new System.Drawing.Size(67, 25);
            this.appleLabel.TabIndex = 7;
            this.appleLabel.Text = "Apple";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(672, 60);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "New York Stock Market ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(36, 381);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(127, 25);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax Amount";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxOutput.Location = new System.Drawing.Point(168, 383);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(164, 23);
            this.taxOutput.TabIndex = 11;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtotalOutput.Location = new System.Drawing.Point(168, 433);
            this.subtotalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(164, 23);
            this.subtotalOutput.TabIndex = 13;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(68, 433);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(91, 25);
            this.subtotalLabel.TabIndex = 12;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalOutput.Location = new System.Drawing.Point(168, 481);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(164, 23);
            this.totalOutput.TabIndex = 15;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(90, 481);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(116, 585);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(254, 67);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(174, 546);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(4);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(164, 31);
            this.tenderedInput.TabIndex = 17;
            this.tenderedInput.Text = "0";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(52, 550);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(110, 25);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Tendered ";
            // 
            // dashsLabel
            // 
            this.dashsLabel.AutoSize = true;
            this.dashsLabel.Location = new System.Drawing.Point(112, 519);
            this.dashsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashsLabel.Name = "dashsLabel";
            this.dashsLabel.Size = new System.Drawing.Size(327, 25);
            this.dashsLabel.TabIndex = 19;
            this.dashsLabel.Text = "---------------------------------------------";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(68, 667);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(93, 25);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change ";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeOutput.Location = new System.Drawing.Point(168, 667);
            this.changeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(164, 23);
            this.changeOutput.TabIndex = 21;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(40, 708);
            this.printButton.Margin = new System.Windows.Forms.Padding(4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(392, 38);
            this.printButton.TabIndex = 22;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receipt.Location = new System.Drawing.Point(436, 104);
            this.receipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(344, 482);
            this.receipt.TabIndex = 24;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(515, 607);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(209, 39);
            this.purchaseButton.TabIndex = 25;
            this.purchaseButton.Text = "New Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 785);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.dashsLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.appleLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.shopifyLabel);
            this.Controls.Add(this.teslaLabel);
            this.Controls.Add(this.shopifyInput);
            this.Controls.Add(this.teslaInput);
            this.Controls.Add(this.appleInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appleInput;
        private System.Windows.Forms.TextBox teslaInput;
        private System.Windows.Forms.TextBox shopifyInput;
        private System.Windows.Forms.Label teslaLabel;
        private System.Windows.Forms.Label shopifyLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label appleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label dashsLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Button purchaseButton;
    }
}

