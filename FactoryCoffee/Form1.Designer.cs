namespace FactoryCoffee
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
            this.rbtnItalian = new System.Windows.Forms.RadioButton();
            this.rbtnAmerican = new System.Windows.Forms.RadioButton();
            this.btnEspresso = new System.Windows.Forms.Button();
            this.btnLatte = new System.Windows.Forms.Button();
            this.btnAmericano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnItalian
            // 
            this.rbtnItalian.AutoSize = true;
            this.rbtnItalian.Location = new System.Drawing.Point(225, 175);
            this.rbtnItalian.Name = "rbtnItalian";
            this.rbtnItalian.Size = new System.Drawing.Size(112, 17);
            this.rbtnItalian.TabIndex = 0;
            this.rbtnItalian.TabStop = true;
            this.rbtnItalian.Text = "Italian CoffeeShop";
            this.rbtnItalian.UseVisualStyleBackColor = true;
            this.rbtnItalian.CheckedChanged += new System.EventHandler(this.rbtnItalian_CheckedChanged);
            // 
            // rbtnAmerican
            // 
            this.rbtnAmerican.AutoSize = true;
            this.rbtnAmerican.Location = new System.Drawing.Point(225, 222);
            this.rbtnAmerican.Name = "rbtnAmerican";
            this.rbtnAmerican.Size = new System.Drawing.Size(128, 17);
            this.rbtnAmerican.TabIndex = 1;
            this.rbtnAmerican.TabStop = true;
            this.rbtnAmerican.Text = "American CoffeeShop";
            this.rbtnAmerican.UseVisualStyleBackColor = true;
            this.rbtnAmerican.CheckedChanged += new System.EventHandler(this.rbtnAmerican_CheckedChanged);
            // 
            // btnEspresso
            // 
            this.btnEspresso.Location = new System.Drawing.Point(433, 147);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(75, 23);
            this.btnEspresso.TabIndex = 3;
            this.btnEspresso.Text = "Espresso";
            this.btnEspresso.UseVisualStyleBackColor = true;
            this.btnEspresso.Click += new System.EventHandler(this.btnEspresso_Click);
            // 
            // btnLatte
            // 
            this.btnLatte.Location = new System.Drawing.Point(433, 194);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(75, 23);
            this.btnLatte.TabIndex = 4;
            this.btnLatte.Text = "Latte";
            this.btnLatte.UseVisualStyleBackColor = true;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // btnAmericano
            // 
            this.btnAmericano.Location = new System.Drawing.Point(433, 241);
            this.btnAmericano.Name = "btnAmericano";
            this.btnAmericano.Size = new System.Drawing.Size(75, 23);
            this.btnAmericano.TabIndex = 5;
            this.btnAmericano.Text = "Americano";
            this.btnAmericano.UseVisualStyleBackColor = true;
            this.btnAmericano.Click += new System.EventHandler(this.btnAmericano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAmericano);
            this.Controls.Add(this.btnLatte);
            this.Controls.Add(this.btnEspresso);
            this.Controls.Add(this.rbtnAmerican);
            this.Controls.Add(this.rbtnItalian);
            this.Name = "Form1";
            this.Text = "r";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnItalian;
        private System.Windows.Forms.RadioButton rbtnAmerican;
        private System.Windows.Forms.Button btnEspresso;
        private System.Windows.Forms.Button btnLatte;
        private System.Windows.Forms.Button btnAmericano;
    }
}

