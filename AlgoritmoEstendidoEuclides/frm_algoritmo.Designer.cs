namespace AlgoritmoEstendidoEuclides
{
    partial class frm_algoritmo
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
            txt_resultado = new TextBox();
            btn_calcular = new Button();
            num_a = new NumericUpDown();
            num_b = new NumericUpDown();
            lbl_numa = new Label();
            lbl_numb = new Label();
            ((System.ComponentModel.ISupportInitialize)num_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_b).BeginInit();
            SuspendLayout();
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 18F);
            txt_resultado.Location = new Point(38, 75);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(301, 364);
            txt_resultado.TabIndex = 3;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(38, 39);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(301, 27);
            btn_calcular.TabIndex = 2;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // num_a
            // 
            num_a.Location = new Point(109, 11);
            num_a.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_a.Name = "num_a";
            num_a.Size = new Size(65, 23);
            num_a.TabIndex = 0;
            // 
            // num_b
            // 
            num_b.Location = new Point(274, 11);
            num_b.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_b.Name = "num_b";
            num_b.Size = new Size(65, 23);
            num_b.TabIndex = 1;
            // 
            // lbl_numa
            // 
            lbl_numa.AutoSize = true;
            lbl_numa.Location = new Point(38, 15);
            lbl_numa.Name = "lbl_numa";
            lbl_numa.Size = new Size(65, 15);
            lbl_numa.TabIndex = 4;
            lbl_numa.Text = "Número A:";
            // 
            // lbl_numb
            // 
            lbl_numb.AutoSize = true;
            lbl_numb.Location = new Point(204, 15);
            lbl_numb.Name = "lbl_numb";
            lbl_numb.Size = new Size(64, 15);
            lbl_numb.TabIndex = 5;
            lbl_numb.Text = "Número B:";
            // 
            // frm_algoritmo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(lbl_numb);
            Controls.Add(lbl_numa);
            Controls.Add(num_b);
            Controls.Add(num_a);
            Controls.Add(txt_resultado);
            Controls.Add(btn_calcular);
            Name = "frm_algoritmo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritmo Estendido de Euclides";
            ((System.ComponentModel.ISupportInitialize)num_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_b).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_resultado;
        private Button btn_calcular;
        private NumericUpDown num_a;
        private NumericUpDown num_b;
        private Label lbl_numa;
        private Label lbl_numb;
    }
}
