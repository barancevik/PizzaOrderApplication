namespace PizzaorderApplication
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
            this.lblPizzas = new System.Windows.Forms.Label();
            this.lstPizzas = new System.Windows.Forms.ListBox();
            this.lblSizes = new System.Windows.Forms.Label();
            this.CbSizes = new System.Windows.Forms.ComboBox();
            this.gbDough = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPieces = new System.Windows.Forms.TextBox();
            this.lblPieces = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.gbDough.SuspendLayout();
            this.gbIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPizzas
            // 
            this.lblPizzas.AutoSize = true;
            this.lblPizzas.Location = new System.Drawing.Point(13, 98);
            this.lblPizzas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPizzas.Name = "lblPizzas";
            this.lblPizzas.Size = new System.Drawing.Size(59, 20);
            this.lblPizzas.TabIndex = 7;
            this.lblPizzas.Text = "Pizzas:";
            // 
            // lstPizzas
            // 
            this.lstPizzas.FormattingEnabled = true;
            this.lstPizzas.ItemHeight = 20;
            this.lstPizzas.Location = new System.Drawing.Point(85, 98);
            this.lstPizzas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPizzas.Name = "lstPizzas";
            this.lstPizzas.Size = new System.Drawing.Size(298, 144);
            this.lstPizzas.TabIndex = 6;
            this.lstPizzas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPizzas_MouseClick);
            // 
            // lblSizes
            // 
            this.lblSizes.AutoSize = true;
            this.lblSizes.Location = new System.Drawing.Point(13, 29);
            this.lblSizes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizes.Name = "lblSizes";
            this.lblSizes.Size = new System.Drawing.Size(52, 20);
            this.lblSizes.TabIndex = 5;
            this.lblSizes.Text = "Sizes:";
            // 
            // CbSizes
            // 
            this.CbSizes.BackColor = System.Drawing.SystemColors.Window;
            this.CbSizes.FormattingEnabled = true;
            this.CbSizes.Location = new System.Drawing.Point(83, 29);
            this.CbSizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbSizes.Name = "CbSizes";
            this.CbSizes.Size = new System.Drawing.Size(300, 28);
            this.CbSizes.TabIndex = 4;
            this.CbSizes.SelectionChangeCommitted += new System.EventHandler(this.CbSizes_SelectionChangeCommitted);
            // 
            // gbDough
            // 
            this.gbDough.Controls.Add(this.radioButton2);
            this.gbDough.Controls.Add(this.radioButton1);
            this.gbDough.Location = new System.Drawing.Point(17, 436);
            this.gbDough.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDough.Name = "gbDough";
            this.gbDough.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDough.Size = new System.Drawing.Size(514, 134);
            this.gbDough.TabIndex = 9;
            this.gbDough.TabStop = false;
            this.gbDough.Text = "Dough";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(268, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Thick crust";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 54);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thin Crust";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbIngredients
            // 
            this.gbIngredients.Controls.Add(this.checkBox12);
            this.gbIngredients.Controls.Add(this.checkBox11);
            this.gbIngredients.Controls.Add(this.checkBox10);
            this.gbIngredients.Controls.Add(this.checkBox9);
            this.gbIngredients.Controls.Add(this.checkBox8);
            this.gbIngredients.Controls.Add(this.checkBox7);
            this.gbIngredients.Controls.Add(this.checkBox6);
            this.gbIngredients.Controls.Add(this.checkBox5);
            this.gbIngredients.Controls.Add(this.checkBox4);
            this.gbIngredients.Controls.Add(this.checkBox3);
            this.gbIngredients.Controls.Add(this.checkBox2);
            this.gbIngredients.Controls.Add(this.checkBox1);
            this.gbIngredients.Location = new System.Drawing.Point(17, 264);
            this.gbIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbIngredients.Size = new System.Drawing.Size(514, 163);
            this.gbIngredients.TabIndex = 8;
            this.gbIngredients.TabStop = false;
            this.gbIngredients.Text = "Ingredients";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(338, 122);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(76, 24);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "Garlic";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(338, 85);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(92, 24);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Chicken";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(338, 49);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(91, 24);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Broccoli";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(338, 14);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(97, 24);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Oregano";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(168, 125);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(118, 24);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Sweet Corn";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(168, 88);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(99, 24);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Sausage";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(168, 51);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(112, 24);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Black Olive";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(168, 14);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(110, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Mushroom";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 128);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Tomatoes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 100);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Red Pepper";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 65);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(170, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mozzarella Cheese";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Cheddar Cheese";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.BackColor = System.Drawing.Color.Yellow;
            this.btnAddToBasket.Location = new System.Drawing.Point(854, 578);
            this.btnAddToBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(171, 60);
            this.btnAddToBasket.TabIndex = 21;
            this.btnAddToBasket.Text = "Add to Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = false;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.Location = new System.Drawing.Point(623, 580);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 26);
            this.txtAmount.TabIndex = 20;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(557, 587);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 19;
            this.lblAmount.Text = "Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Yellow;
            this.btnCalculate.Location = new System.Drawing.Point(325, 580);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 58);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPieces
            // 
            this.txtPieces.Location = new System.Drawing.Point(80, 583);
            this.txtPieces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPieces.Name = "txtPieces";
            this.txtPieces.Size = new System.Drawing.Size(176, 26);
            this.txtPieces.TabIndex = 17;
            // 
            // lblPieces
            // 
            this.lblPieces.AutoSize = true;
            this.lblPieces.Location = new System.Drawing.Point(19, 587);
            this.lblPieces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(60, 20);
            this.lblPieces.TabIndex = 16;
            this.lblPieces.Text = "Pieces:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(687, 448);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total:";
            // 
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(596, 3);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(793, 424);
            this.lstOrder.TabIndex = 24;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.List;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Yellow;
            this.BtnOrder.Location = new System.Drawing.Point(1057, 490);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(332, 162);
            this.BtnOrder.TabIndex = 25;
            this.BtnOrder.Text = "CONFIRM ORDER";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 722);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPieces);
            this.Controls.Add(this.lblPieces);
            this.Controls.Add(this.gbDough);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.lblPizzas);
            this.Controls.Add(this.lstPizzas);
            this.Controls.Add(this.lblSizes);
            this.Controls.Add(this.CbSizes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDough.ResumeLayout(false);
            this.gbDough.PerformLayout();
            this.gbIngredients.ResumeLayout(false);
            this.gbIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzas;
        private System.Windows.Forms.ListBox lstPizzas;
        private System.Windows.Forms.Label lblSizes;
        private System.Windows.Forms.ComboBox CbSizes;
        private System.Windows.Forms.GroupBox gbDough;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPieces;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.Button BtnOrder;
    }
}

