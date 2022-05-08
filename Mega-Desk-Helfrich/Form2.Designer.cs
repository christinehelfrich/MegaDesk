namespace Mega_Desk_Helfrich
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.Label();
            this.numberDrawers = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.Label();
            this.firstNameEntry = new System.Windows.Forms.TextBox();
            this.lastNameEntry = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.deskDrawers = new System.Windows.Forms.TextBox();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.calculateQuote = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.materialInput = new System.Windows.Forms.TextBox();
            this.orderRush = new System.Windows.Forms.TextBox();
            this.saveQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(27, 87);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(132, 16);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "Customer First Name";
            this.firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(27, 127);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(132, 16);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Customer Last Name";
            this.lastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Location = new System.Drawing.Point(27, 172);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(111, 16);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.Text = "Width of Desk (in)";
            this.deskWidth.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Location = new System.Drawing.Point(27, 219);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(113, 16);
            this.deskDepth.TabIndex = 3;
            this.deskDepth.Text = "Depth of Desk (in)";
            // 
            // numberDrawers
            // 
            this.numberDrawers.AutoSize = true;
            this.numberDrawers.Location = new System.Drawing.Point(364, 100);
            this.numberDrawers.Name = "numberDrawers";
            this.numberDrawers.Size = new System.Drawing.Size(122, 16);
            this.numberDrawers.TabIndex = 4;
            this.numberDrawers.Text = "Number of Drawers";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(366, 150);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(104, 16);
            this.surfaceMaterial.TabIndex = 5;
            this.surfaceMaterial.Text = "Surface Material";
            // 
            // rushOrder
            // 
            this.rushOrder.AutoSize = true;
            this.rushOrder.Location = new System.Drawing.Point(366, 201);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(124, 16);
            this.rushOrder.TabIndex = 6;
            this.rushOrder.Text = "Rush Order Options";
            // 
            // firstNameEntry
            // 
            this.firstNameEntry.Location = new System.Drawing.Point(189, 81);
            this.firstNameEntry.Name = "firstNameEntry";
            this.firstNameEntry.Size = new System.Drawing.Size(100, 22);
            this.firstNameEntry.TabIndex = 7;
            this.firstNameEntry.TextChanged += new System.EventHandler(this.firstNameEntry_TextChanged);
            // 
            // lastNameEntry
            // 
            this.lastNameEntry.Location = new System.Drawing.Point(189, 127);
            this.lastNameEntry.Name = "lastNameEntry";
            this.lastNameEntry.Size = new System.Drawing.Size(100, 22);
            this.lastNameEntry.TabIndex = 8;
            this.lastNameEntry.TextChanged += new System.EventHandler(this.lastNameEntry_TextChanged);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(189, 172);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 22);
            this.widthInput.TabIndex = 9;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(189, 219);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(100, 22);
            this.depthInput.TabIndex = 10;
            this.depthInput.TextChanged += new System.EventHandler(this.depthInput_TextChanged);
            // 
            // deskDrawers
            // 
            this.deskDrawers.Location = new System.Drawing.Point(526, 97);
            this.deskDrawers.Name = "deskDrawers";
            this.deskDrawers.Size = new System.Drawing.Size(100, 22);
            this.deskDrawers.TabIndex = 11;
            this.deskDrawers.TextChanged += new System.EventHandler(this.deskDrawers_TextChanged);
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLabel.Location = new System.Drawing.Point(25, 22);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(279, 29);
            this.quoteLabel.TabIndex = 14;
            this.quoteLabel.Text = "Create Your New Quote";
            this.quoteLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // calculateQuote
            // 
            this.calculateQuote.AutoSize = true;
            this.calculateQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateQuote.Location = new System.Drawing.Point(30, 288);
            this.calculateQuote.Name = "calculateQuote";
            this.calculateQuote.Padding = new System.Windows.Forms.Padding(10);
            this.calculateQuote.Size = new System.Drawing.Size(149, 59);
            this.calculateQuote.TabIndex = 15;
            this.calculateQuote.Text = "Calculate";
            this.calculateQuote.UseVisualStyleBackColor = false;
            this.calculateQuote.Click += new System.EventHandler(this.calculateQuote_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(29, 380);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(111, 25);
            this.totalPriceLabel.TabIndex = 16;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(156, 383);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalPriceTextBox.TabIndex = 17;
            this.totalPriceTextBox.Text = "price here";
            // 
            // materialInput
            // 
            this.materialInput.Location = new System.Drawing.Point(526, 150);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(100, 22);
            this.materialInput.TabIndex = 18;
            this.materialInput.TextChanged += new System.EventHandler(this.materialInput_TextChanged);
            // 
            // orderRush
            // 
            this.orderRush.Location = new System.Drawing.Point(526, 201);
            this.orderRush.Name = "orderRush";
            this.orderRush.Size = new System.Drawing.Size(100, 22);
            this.orderRush.TabIndex = 19;
            this.orderRush.TextChanged += new System.EventHandler(this.orderRush_TextChanged);
            // 
            // saveQuoteButton
            // 
            this.saveQuoteButton.AutoSize = true;
            this.saveQuoteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQuoteButton.Location = new System.Drawing.Point(272, 378);
            this.saveQuoteButton.Name = "saveQuoteButton";
            this.saveQuoteButton.Size = new System.Drawing.Size(106, 33);
            this.saveQuoteButton.TabIndex = 20;
            this.saveQuoteButton.Text = "Save Quote";
            this.saveQuoteButton.UseVisualStyleBackColor = false;
            this.saveQuoteButton.Click += new System.EventHandler(this.saveQuoteButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveQuoteButton);
            this.Controls.Add(this.orderRush);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.calculateQuote);
            this.Controls.Add(this.quoteLabel);
            this.Controls.Add(this.deskDrawers);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.lastNameEntry);
            this.Controls.Add(this.firstNameEntry);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.numberDrawers);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form2";
            this.Text = "New Quote";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.Label numberDrawers;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.Label rushOrder;
        private System.Windows.Forms.TextBox firstNameEntry;
        private System.Windows.Forms.TextBox lastNameEntry;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.TextBox deskDrawers;
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Button calculateQuote;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox materialInput;
        private System.Windows.Forms.TextBox orderRush;
        private System.Windows.Forms.Button saveQuoteButton;
    }
}