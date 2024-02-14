namespace FormExample
{
    partial class Orderform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.rdoDeliver = new System.Windows.Forms.RadioButton();
            this.rdoDine = new System.Windows.Forms.RadioButton();
            this.rdoCollection = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoCollection);
            this.groupBox1.Controls.Add(this.rdoDine);
            this.groupBox1.Controls.Add(this.rdoDeliver);
            this.groupBox1.Controls.Add(this.chkGreenPepper);
            this.groupBox1.Controls.Add(this.chkSauce);
            this.groupBox1.Controls.Add(this.chkOnion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkCheese);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Page";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(52, 186);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(62, 17);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Toppings";
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(52, 224);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Location = new System.Drawing.Point(182, 224);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(57, 17);
            this.chkSauce.TabIndex = 3;
            this.chkSauce.Text = "Sauce";
            this.chkSauce.UseVisualStyleBackColor = true;
            this.chkSauce.CheckedChanged += new System.EventHandler(this.chkSauce_CheckedChanged);
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(182, 186);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.chkGreenPepper.TabIndex = 4;
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // rdoDeliver
            // 
            this.rdoDeliver.AutoSize = true;
            this.rdoDeliver.Location = new System.Drawing.Point(452, 186);
            this.rdoDeliver.Name = "rdoDeliver";
            this.rdoDeliver.Size = new System.Drawing.Size(58, 17);
            this.rdoDeliver.TabIndex = 5;
            this.rdoDeliver.TabStop = true;
            this.rdoDeliver.Text = "Deliver";
            this.rdoDeliver.UseVisualStyleBackColor = true;
            this.rdoDeliver.CheckedChanged += new System.EventHandler(this.rdoDeliver_CheckedChanged);
            // 
            // rdoDine
            // 
            this.rdoDine.AutoSize = true;
            this.rdoDine.Location = new System.Drawing.Point(452, 223);
            this.rdoDine.Name = "rdoDine";
            this.rdoDine.Size = new System.Drawing.Size(59, 17);
            this.rdoDine.TabIndex = 6;
            this.rdoDine.TabStop = true;
            this.rdoDine.Text = "Dine In";
            this.rdoDine.UseVisualStyleBackColor = true;
            this.rdoDine.CheckedChanged += new System.EventHandler(this.rdoDine_CheckedChanged);
            // 
            // rdoCollection
            // 
            this.rdoCollection.AutoSize = true;
            this.rdoCollection.Location = new System.Drawing.Point(452, 266);
            this.rdoCollection.Name = "rdoCollection";
            this.rdoCollection.Size = new System.Drawing.Size(63, 17);
            this.rdoCollection.TabIndex = 7;
            this.rdoCollection.TabStop = true;
            this.rdoCollection.Text = "Pick Up";
            this.rdoCollection.UseVisualStyleBackColor = true;
            this.rdoCollection.CheckedChanged += new System.EventHandler(this.rdoCollection_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dinning Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pizz Order Form";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(425, 311);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(139, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "______________________";
            // 
            // Orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orderform";
            this.Text = "Orderform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoCollection;
        private System.Windows.Forms.RadioButton rdoDine;
        private System.Windows.Forms.RadioButton rdoDeliver;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
    }
}